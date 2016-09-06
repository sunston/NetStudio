using System;
using System.IO; 
using System.Runtime.InteropServices;  
using System.Windows.Forms;
using System.Threading;

using System.CodeDom.Compiler;
using NetStudio.Document;  

namespace NetStudio
{
    //Основная форма приложения
    public partial class MainForm : Form
    {
        //Тип ошибки
        public enum ErrorType
        {
            CompilerError = 0,
            RunTimeError = 1
        }

        CCSDocument m_Document;
        Thread m_RunThread;

        private System.Threading.Timer m_CompileTimer;
        private const int cCompileDelay = 500;

        public MainForm()
        {
            InitializeComponent();
            CreateNewDocument(CCSLanguage.CSharp);  
        }

        //Работа с документом--начало--
        #region Document
        private void CreateNewDocument(CCSLanguage _language)
        {
            ValidateDocumentSave();
            m_Document = new CCSDocument(_language);
            UpdateDocumentControls();
        }

        private void ValidateDocumentSave()
        {
            if (m_Document == null)
                return;

            if (m_Document.IsChanged)
                if (MessageBox.Show("Current code had been changed. Save changes'" + m_Document.Name + "'?", "Save changes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    saveOperation_Click(this, new EventArgs());  
        }

        private void UpdateDocumentControls()
        {
            this.textBoxCode.Text = m_Document.Code;
            this.Text = Application.ProductName + " - " + m_Document.Name;

            saveToolStripMenuItem.Enabled = true;
            SavetoolStripButton.Enabled  = true;

            saveAsToolStripMenuItem.Enabled = File.Exists(m_Document.Name);
            toolStripStatusLabelLanguage.Text = "Current language: " + CCSDocument.GetCodeName(m_Document.Language);

            propertyGrid.SelectedObject = m_Document;
        }

        private string GetFileFilter(CCSLanguage _language)
        {
            return CCSDocument.GetCodeFileName(_language) + " (*." + CCSDocument.GetCodeFileExtension(_language) + ")|*." + CCSDocument.GetCodeFileExtension(_language);
        }
        #endregion
        //Работа с документом--конец--
        //Компиляция программы--начало--
        #region Compilation
        private void textBoxCode_TextChanged(object sender, EventArgs e)
        {
            if (m_CompileTimer == null)
                m_CompileTimer = new System.Threading.Timer(Compile, "Compile", cCompileDelay, 0);
            else
                m_CompileTimer.Change(cCompileDelay, 0);
        }

        private void BeforeCompile()
        {
            if (listViewCompilerErrors.InvokeRequired)
            {
                listViewCompilerErrors.Invoke(new MethodInvoker(() =>
                {
                    BeforeCompile();
                }));

                return;
            }

            RuntoolStripButton.Enabled = false;
            runToolStripMenuItem.Enabled = false;
        }

        private void AfterCompile()
        {
            if (listViewCompilerErrors.InvokeRequired)
            {
                listViewCompilerErrors.Invoke(new MethodInvoker(() =>
                {
                    AfterCompile();
                }));

                return;
            }

            bool _IsRunnable = true;

            if (m_RunThread != null && m_RunThread.IsAlive)
                _IsRunnable = false;

            RuntoolStripButton.Enabled = _IsRunnable;
            runToolStripMenuItem.Enabled = _IsRunnable;
        }

        private void Compile(object sender)
        {
            try
            {
                BeforeCompile();

                SelectErrorList(ErrorType.CompilerError);
                ClearErrorsList(ErrorType.CompilerError);

                m_Document.Code = textBoxCode.Text;
                m_Document.Compile();

                AfterCompile();
            }
            catch (CCSSettingsException ex)
            {
                LogError(ErrorType.CompilerError, ex.Message);
            }
            catch (CCSRunTimeException ex)
            {
                LogError(ErrorType.CompilerError, ex.Message);

                foreach (CompilerError _error in m_Document.CompileResults.Errors)
                    LogError(_error.ErrorText, _error);
            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message, "Ошибка компиляции");
            }
        }

        private delegate void BuildDelegate(string _destination);

        private void Build(BuildDelegate _build, string _destination)
        {
            try
            {
                SelectErrorList(ErrorType.CompilerError);
                ClearErrorsList(ErrorType.CompilerError);

                _build(_destination);
            }
            catch (CCSSettingsException ex)
            {
                LogError(ErrorType.CompilerError, ex.Message);
                ErrorMessage(ex.Message, "Ошибка сборки");
            }
            catch (CCSRunTimeException ex)
            {
                LogError(ErrorType.CompilerError, ex.Message);

                foreach (CompilerError _error in m_Document.CompileResults.Errors)
                    LogError(_error.ErrorText, _error);

                ErrorMessage(ex.Message, "Ошибка сборки");
            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message, "Ошибка сборки");
            }
        }
        #endregion
        //Компиляция программы--конец--
        //Запуск программы--начало--
        #region Running
        private void RunOperation_Click(object sender, EventArgs e)
        {
            RuntoolStripButton.Enabled = false;
            runToolStripMenuItem.Enabled = false;

            SelectErrorList(ErrorType.RunTimeError);
            ClearErrorsList(ErrorType.RunTimeError);

            propertyGrid.SelectedObject = m_Document.CompiledAssembly;

            m_RunThread = new Thread(new ThreadStart(Run));
            m_RunThread.IsBackground = true;
            m_RunThread.Start();

            StoptoolStripButton.Enabled = true;
            stopToolStripMenuItem.Enabled = true;
        }

        private void Run()
        {
            try
            {
                if (m_Document.UseConsole)
                {
                    try
                    {
                        Win32.AllocConsole();
                    }
                    catch { }
                }

                m_Document.Run();
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
            finally
            {
                AfterRun();
            }
        }

        private void StopOperation_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void Stop()
        {
            if (m_RunThread == null)
                return;

            if (!m_RunThread.IsAlive)
                return;

            try
            {
                m_RunThread.Abort();
            }
            catch (Exception ex)
            {
                LogError(ErrorType.RunTimeError, ex.Message);
            }
            finally
            {
                AfterRun();
            }
        }

        private void AfterRun()
        {
            if (listViewCompilerErrors.InvokeRequired)
            {
                listViewCompilerErrors.Invoke(new MethodInvoker(() =>
                {
                    AfterRun();
                }));

                return;
            }

            RuntoolStripButton.Enabled = true;
            runToolStripMenuItem.Enabled = true;

            StoptoolStripButton.Enabled = false;
            stopToolStripMenuItem.Enabled = false;

            m_RunThread = null;

            if (m_Document.UseConsole)
            {
                try
                {
                    Win32.FreeConsole();
                }
                catch { }
            }

            propertyGrid.SelectedObject = m_Document;
        }
        #endregion
        //Запуск программы--конец--
        //Обработка исключений--начало--
        #region Logging
        private void LogError(ErrorType _errorType, string _message)
        {
            if (listViewCompilerErrors.InvokeRequired)
            {
                listViewCompilerErrors.Invoke(new MethodInvoker(() =>
                {
                    LogError(_errorType, _message);
                }));

                return;
            }

            ListViewItem _item = GetListView(_errorType).Items.Add((GetListView(_errorType).Items.Count + 1).ToString());
            _item.SubItems.Add(_message);
        }

        private void LogError(string _message, CompilerError _error)
        {
            if (listViewCompilerErrors.InvokeRequired)
            {
                listViewCompilerErrors.Invoke(new MethodInvoker(() =>
                {
                    LogError(_message, _error);
                }));

                return;
            }

            ListViewItem _item = GetListView(ErrorType.CompilerError).Items.Add((GetListView(ErrorType.CompilerError).Items.Count + 1).ToString());
            _item.SubItems.Add(_message);
            _item.Tag = _error;
        }

        private void LogError(Exception ex)
        {
            if (listViewCompilerErrors.InvokeRequired)
            {
                listViewCompilerErrors.Invoke(new MethodInvoker(() =>
                {
                    LogError(ex);
                }));

                return;
            }

            ListViewItem _item = GetListView(ErrorType.RunTimeError).Items.Add((GetListView(ErrorType.RunTimeError).Items.Count + 1).ToString());
            _item.SubItems.Add(ex.Message);
            _item.SubItems.Add(ex.StackTrace);
            _item.Tag = ex;

            if (ex.InnerException != null)
                LogError(ex.InnerException);
        }

        private void ClearErrorsList(ErrorType _errorType)
        {
            if (listViewCompilerErrors.InvokeRequired)
            {
                listViewCompilerErrors.Invoke(new MethodInvoker(() =>
                {
                    ClearErrorsList(_errorType);
                }));

                return;
            }

            GetListView(_errorType).Items.Clear();
        }

        private void SelectErrorList(ErrorType _errorType)
        {
            if (tabControlStatus.InvokeRequired)
            {
                listViewCompilerErrors.Invoke(new MethodInvoker(() =>
                {
                    SelectErrorList(_errorType);
                }));

                return;
            }

            switch (_errorType)
            {
                case ErrorType.CompilerError: { tabControlStatus.SelectedTab = tabPageCompilerErrors; break; }
                case ErrorType.RunTimeError: { tabControlStatus.SelectedTab = tabPageRunTimeErrors; break; }
            }
        }

        private ListView GetListView(ErrorType _errorType)
        {
            switch (_errorType)
            {
                case ErrorType.CompilerError: { return listViewCompilerErrors; }
                case ErrorType.RunTimeError: { return listViewRuntimeErrors; }
            }

            return null;
        }

        private void ErrorMessage(string _message, string _caption)
        {
            if (listViewCompilerErrors.InvokeRequired)
            {
                listViewCompilerErrors.Invoke(new MethodInvoker(() =>
                {
                    ErrorMessage(_message, _caption);
                }));

                return;
            }

            MessageBox.Show(_message, _caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
        //Обработка исключений--конец--
        //Обработка событий пользовательского интерфейса--начало--
        #region Eventhandling
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Splash _splash = new Splash();
            _splash.ShowDialog();  
        }

        private void listViewCompilerErrors_MouseUp(object sender, EventArgs e)
        {
            if (listViewCompilerErrors.SelectedItems.Count == 0)
                return;

            ListViewItem _item = listViewCompilerErrors.SelectedItems[0];

            if (_item == null)
                return;

            CompilerError _error;
            _error = (CompilerError)_item.Tag;

            if (_error == null)
                return;

            int _Position = 0;

            for (int i = 0; i < _error.Line - 1; i++)
                _Position = _Position + textBoxCode.Lines[i].Length + 2;

            textBoxCode.Select(_Position, textBoxCode.Lines[_error.Line - 1].Length); 
            textBoxCode.ScrollToCaret();
            textBoxCode.Focus();
        }

        private void saveOperation_Click(object sender, EventArgs e)
        {
            if (!File.Exists(m_Document.Name))
            {
                saveAsOperation_Click(sender, e);
                return;
            }

            m_Document.Save(m_Document.Name);   
        }

        private void saveAsOperation_Click(object sender, EventArgs e)
        {
            SaveFileDialog _dlg = new SaveFileDialog();
            _dlg.Filter = GetFileFilter(m_Document.Language);
            _dlg.ShowDialog();

            if (string.IsNullOrEmpty(_dlg.FileName))
                return;

            m_Document.Save(_dlg.FileName);
            UpdateDocumentControls(); 
        }

        private void OpenOperation_Click(object sender, EventArgs e)
        {
            ValidateDocumentSave();

            OpenFileDialog _dlg = new OpenFileDialog();
            _dlg.Filter = GetFileFilter(CCSLanguage.CSharp) + "|" + GetFileFilter(CCSLanguage.VisualBasic);
            _dlg.ShowDialog();

            if (string.IsNullOrEmpty(_dlg.FileName))
                return;

            m_Document.Open(_dlg.FileName);
            UpdateDocumentControls();
        }

        private void NewOperation_Click(object sender, EventArgs e)
        {
            LanguageForm _dlg = new LanguageForm();
            _dlg.ShowDialog();

            if (!_dlg.Result)
                return;

            CreateNewDocument(_dlg.Language); 
        }

        private void BuildExeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog _dlg = new SaveFileDialog();
            _dlg.Filter = "Executable files (*.exe)|*.exe";
            _dlg.ShowDialog();

            if (string.IsNullOrEmpty(_dlg.FileName))
                return;

            Build(m_Document.BuildExecutable, _dlg.FileName);
        }

        private void BuildDllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog _dlg = new SaveFileDialog();
            _dlg.Filter = "Dynamic link libraries files (*.dll)|*.dll";
            _dlg.ShowDialog();

            if (string.IsNullOrEmpty(_dlg.FileName))
                return;

            Build(m_Document.BuildDynamicLinkLibrary, _dlg.FileName);   
        }

        private void RefreshtoolStripButton_Click(object sender, EventArgs e)
        {
            m_Document.Code = string.Empty;
            Compile(null);
        }
        #endregion

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void listViewCompilerErrors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Обработка событий пользовательского интерфейса--конец--
    }

    public class Win32
    {
        /// <summary>
        /// Allocates a new console for current process.
        /// </summary>
        [DllImport("kernel32.dll")]
        public static extern Boolean AllocConsole();

        /// <summary>
        /// Frees the console.
        /// </summary>
        [DllImport("kernel32.dll")]
        public static extern Boolean FreeConsole();
    }
}

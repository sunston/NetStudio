using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.CodeDom.Compiler;

using System.Reflection;
using Microsoft.CSharp;
using Microsoft.VisualBasic;

using System.Windows.Forms;

namespace NetStudio
{
    //Основые сервисы Coding Craft Studio
    namespace Document
    {
        //Поддерживаемые языки программирования
        public enum CCSLanguage
        {
            CSharp = 0,
            VisualBasic = 1
        }

        //Документ приложения (исходный код, список библиотек)
        public class CCSDocument
        {
            //Вспомогательный класс для редактирования списка ссылок на библиотеки стандартными средствами PropertyGrid
            public class CCSString
            {
                public CCSString() { }
                public CCSString(string _string) : base() { this.Value = _string; }
                public string Value { get; set; }

                public override string ToString()
                {
                    return this.Value;
                }
            }

            //Конструктор документа (программы на языке программирования _lang)
            public CCSDocument(CCSLanguage _lang)
            {
                this.Language = _lang;
                this.Name = "Новый документ";
                this.NameSpace = "Application";
                this.ApplicationTypeName = "Application";
                this.CompilerOptions = "/optimize";
                this.IncludeDebugInformation = true;
                this.TreatWarningsAsErrors = true;
                this.UseConsole = true;

                //Добавление основной библиотеки BCL
                m_References = new List<CCSString>();
                m_References.Add(new CCSString("System.dll"));

                //Формирование программного кода по умолчанию
                switch (this.Language)
                {
                    case CCSLanguage.CSharp:
                        {
                            this.Code = "using System;" + Environment.NewLine + Environment.NewLine
                                + "namespace " + this.NameSpace + "{" + Environment.NewLine + "  public class " + this.ApplicationTypeName + Environment.NewLine
                                + "  {" + Environment.NewLine + "    public static void Main()" + Environment.NewLine + "    {" + Environment.NewLine + "    }" + Environment.NewLine
                                + "  }" + Environment.NewLine + "}";

                            break;
                        }

                    case CCSLanguage.VisualBasic:
                        {
                            this.Code = "Imports Microsoft.VisualBasic.Interaction" + Environment.NewLine
                                + "Imports System" + Environment.NewLine + Environment.NewLine
                                + "Namespace " + this.NameSpace + Environment.NewLine + "  Public Class " + this.ApplicationTypeName + Environment.NewLine
                                + "    public Shared Sub Main()" + Environment.NewLine + Environment.NewLine + "    End Sub" + Environment.NewLine
                                + "  End Class" + Environment.NewLine + "End Namespace";

                            break;
                        }
                }

                //Сборс флага наличия изменений
                this.IsChanged = false;
            }

            private string m_Code;
            private bool m_CompilationIsRequired = true;

            CompilerParameters m_CompilerParameters;
            CompilerResults m_CompilerResults;
            List<CCSString> m_References;

            //Нередактируемые свойства документа (скрытые в PropertyGrid)
            [System.ComponentModel.Browsable(false)]
            public bool IsChanged { get; private set; }
            [System.ComponentModel.Browsable(false)]
            public CompilerResults CompileResults { get { return m_CompilerResults; } }

            //Редактируемые свойства документа (открытые в PropertyGrid)
            [System.ComponentModel.Category("Сборка"), System.ComponentModel.Description("Язык программирования.")]
            public CCSLanguage Language { get; private set; }
            [System.ComponentModel.Category("Документ"), System.ComponentModel.Description("Имя документа.")]
            public string Name { get; set; }
            [System.ComponentModel.Category("Сборка"), System.ComponentModel.Description("Пространство имен.")]
            public string NameSpace { get; set; }
            [System.ComponentModel.Category("Сборка"), System.ComponentModel.Description("Имя класса проложения.")]
            public string ApplicationTypeName { get; set; }
            [System.ComponentModel.Category("Сборка"), System.ComponentModel.Description("Настройки компилятора.")]
            public string CompilerOptions { get; set; }
            [System.ComponentModel.Category("Сборка"), System.ComponentModel.Description("Включени отладочной информации в сборку.")]
            public bool IncludeDebugInformation { get; set; }
            [System.ComponentModel.Category("Сборка"), System.ComponentModel.Description("Принимать предупреждения за ошибки.")]
            public bool TreatWarningsAsErrors { get; set; }
            [System.ComponentModel.Category("Время выполнения"), System.ComponentModel.Description("Наличие консоли.")]
            public bool UseConsole { get; set; }
            [System.ComponentModel.Category("Сборка"), System.ComponentModel.Description("Список ссылок на внешние сборки.")]
            public List<CCSString> References { get { return m_References; } }

            //Сохранение документа и ссылок в текстовых файлах
            public void Save(string _destination)
            {
                using (StreamWriter _writer = File.CreateText(_destination))
                {
                    _writer.Write(this.Code);
                }

                this.Name = _destination;
                this.IsChanged = false;

                using (StreamWriter _writer = File.CreateText(_destination + ".ccs"))
                {
                    foreach (CCSString _reference in this.References)
                        _writer.WriteLine("reference = " + _reference.Value);

                    _writer.WriteLine("namespace = " + this.NameSpace);
                    _writer.WriteLine("applicationtype = " + this.ApplicationTypeName);
                    _writer.WriteLine("compileroptions = " + this.CompilerOptions);
                    _writer.WriteLine("includedebuginformation = " + this.IncludeDebugInformation.ToString());
                    _writer.WriteLine("treatwarningsaserrors = " + this.TreatWarningsAsErrors.ToString());
                    _writer.WriteLine("useconsole = " + this.UseConsole.ToString());
                }
            }

            //Чтение документа и ссылок из текстовых файлов
            public void Open(string _source)
            {
                switch (System.IO.Path.GetExtension(_source))
                {
                    case ".cs": { this.Language = CCSLanguage.CSharp; break; }
                    case ".vb": { this.Language = CCSLanguage.VisualBasic; break; }
                }

                string _Code = string.Empty;

                using (StreamReader _reader = File.OpenText(_source))
                {
                    _Code = _reader.ReadToEnd();
                }

                string _ccsSettingsName = _source + ".ccs";

                if (File.Exists(_ccsSettingsName))
                {
                    m_References.Clear();

                    using (StreamReader _reader = File.OpenText(_ccsSettingsName))
                    {
                        string _setting = null;

                        do
                        {
                            _setting = _reader.ReadLine();

                            if (_setting != null)
                            {
                                int _pos = _setting.IndexOf("=");

                                if (_pos > 0)
                                {
                                    string _settingName = _setting.Substring(0, _pos).Trim();
                                    string _settingValue = _setting.Substring(_pos + 1, _setting.Length - _pos - 1).Trim();

                                    switch (_settingName)
                                    {
                                        case "reference": { m_References.Add(new CCSString(_settingValue)); break; }
                                        case "namespace": { this.NameSpace = _settingValue; break; }
                                        case "applicationtype": { this.ApplicationTypeName = _settingValue; break; }
                                        case "compileroptions": { this.CompilerOptions = _settingValue; break; }
                                        case "includedebuginformation":
                                            {
                                                try
                                                {
                                                    this.IncludeDebugInformation = System.Convert.ToBoolean(_settingValue);
                                                }
                                                catch { }
                                                break;
                                            }
                                        case "treatwarningsaserrors":
                                            {
                                                try
                                                {
                                                    this.TreatWarningsAsErrors = System.Convert.ToBoolean(_settingValue);
                                                }
                                                catch { }
                                                break;
                                            }
                                        case "useconsole":
                                            {
                                                try
                                                {
                                                    this.UseConsole = System.Convert.ToBoolean(_settingValue);
                                                }
                                                catch { }
                                                break;
                                            }
                                    }
                                }
                            }

                        } while (_setting != null);
                    }
                }

                this.Code = _Code;
                this.Name = _source;
                this.IsChanged = false;
            }

            //Вспомогательные сервисы
            public static string GetCodeName(CCSLanguage _language)
            {
                switch (_language)
                {
                    case CCSLanguage.CSharp:
                        {
                            return "c#";
                        }

                    case CCSLanguage.VisualBasic:
                        {
                            return "vb.net";
                        }
                }

                return "text";
            }

            public static string GetCodeFileName(CCSLanguage _language)
            {
                return GetCodeName(_language) + " files";
            }

            public static string GetCodeFileExtension(CCSLanguage _language)
            {
                switch (_language)
                {
                    case CCSLanguage.CSharp:
                        {
                            return "cs";
                        }

                    case CCSLanguage.VisualBasic:
                        {
                            return "vb";
                        }
                }

                return "txt";
            }

            //Компиляция программы
            public void Compile()
            {
                if (!m_CompilationIsRequired)
                    return;

                m_CompilerParameters = new CompilerParameters();
                m_CompilerParameters.GenerateInMemory = true;
                m_CompilerParameters.GenerateExecutable = true;

                Compile(m_CompilerParameters, ref m_CompilerResults);

                m_CompilationIsRequired = false;
            }

            //Создание exe файла
            public void BuildExecutable(string _destination)
            {
                CompilerParameters _CompilerParameters = new CompilerParameters();
                _CompilerParameters.GenerateInMemory = false;
                _CompilerParameters.GenerateExecutable = true;
                _CompilerParameters.OutputAssembly = _destination;

                CompilerResults _CompilerResults = null;

                Compile(_CompilerParameters, ref _CompilerResults);
            }

            //Создание dll файла
            public void BuildDynamicLinkLibrary(string _destination)
            {
                CompilerParameters _CompilerParameters = new CompilerParameters();
                _CompilerParameters.GenerateInMemory = false;
                _CompilerParameters.GenerateExecutable = false;
                _CompilerParameters.OutputAssembly = _destination;

                CompilerResults _CompilerResults = null;

                Compile(_CompilerParameters, ref _CompilerResults);
            }

            //Динамическая компиляция программного кода
            private void Compile(CompilerParameters _CompilerParameters, ref CompilerResults _CompilerResults)
            {
                _CompilerParameters.CompilerOptions = this.CompilerOptions;

                foreach (CCSString _Reference in m_References)
                    _CompilerParameters.ReferencedAssemblies.Add(_Reference.Value);

                CodeDomProvider _Provider = null;

                switch (this.Language)
                {
                    case CCSLanguage.CSharp:
                        {
                            _Provider = new CSharpCodeProvider();
                            break;
                        }
                    case CCSLanguage.VisualBasic:
                        {
                            _Provider = new VBCodeProvider();
                            break;
                        }
                }

                if (_CompilerParameters.GenerateExecutable)
                    if (_Provider.Supports(GeneratorSupport.EntryPointMethod))
                        _CompilerParameters.MainClass = this.NameSpace + "." + this.ApplicationTypeName;

                _CompilerResults = _Provider.CompileAssemblyFromSource(_CompilerParameters, this.Code);

                if (_CompilerResults.Errors.Count > 0)
                    throw new CCSRunTimeException("Ошибки компиляции!");
            }

            //Программный код
            [System.ComponentModel.Browsable(false)]
            public string Code
            {
                get { return m_Code; }
                set
                {
                    if (m_Code == value)
                        return;

                    m_Code = value;
                    m_CompilationIsRequired = true;

                    this.IsChanged = true;
                }
            }

            //Динамическая сборка
            [System.ComponentModel.Browsable(false)]
            public Assembly CompiledAssembly
            {
                get
                {
                    if (m_CompilerResults == null)
                        return null;

                    return m_CompilerResults.CompiledAssembly;
                }
            }

            //Тип приложения
            [System.ComponentModel.Browsable(false)]
            public Type ApplicationType
            {
                get { return this.CompiledType(this.ApplicationTypeName); }
            }

            //Получение типа динамической сборки по имени
            [System.ComponentModel.Browsable(false)]
            public Type CompiledType(string _Name)
            {
                if (m_CompilerResults == null)
                    return null;

                if (_Name == string.Empty)
                    return null;

                return m_CompilerResults.CompiledAssembly.GetType(_Name);
            }

            //Создание экземпляра типа
            public object CreateInstance(Type _Type)
            {
                return _Type.GetConstructor(Type.EmptyTypes).Invoke(null);
            }

            //Запуск приложения
            public void Run()
            {
                if (string.IsNullOrEmpty(this.ApplicationTypeName))
                    throw new CCSSettingsException("Не задан класс приложения: ApplicationTypeName!");

                this.Compile();

                Type _type;
                _type = this.CompiledType(this.NameSpace + "." + this.ApplicationTypeName);

                if (_type == null)
                    throw new CCSRunTimeException("Класс " + this.ApplicationTypeName + " не определен!");

                MethodInfo _entryPoint;
                _entryPoint = this.CompiledAssembly.EntryPoint;

                if (_entryPoint == null)
                    throw new CCSRunTimeException("Не определена точка входа!");

                object _object;
                _object = this.CreateInstance(_type);

                if (_object == null)
                    throw new CCSRunTimeException("Не удалось создать экземпляр " + this.ApplicationTypeName + "!");

                try
                {
                    _type.InvokeMember(_entryPoint.Name, BindingFlags.InvokeMethod, null, _object, null);
                }
                catch (Exception ex)
                {
                    throw new CCSRunTimeException("Не удалось вызвать метод точки входа " + _entryPoint.Name + " приложения " + this.ApplicationTypeName + "! " + ex.Message, ex);
                }
            }
        }

        //Класс исключения времени исполнения
        public class CCSRunTimeException : Exception
        {
            public CCSRunTimeException()
                : base()
            { }

            public CCSRunTimeException(string message)
                : base(message)
            { }

            public CCSRunTimeException(string message, Exception innerException)
                : base(message, innerException)
            { }

            public CCSRunTimeException(System.Runtime.Serialization.SerializationInfo info
                , System.Runtime.Serialization.StreamingContext context)
                : base(info, context)
            { }
        }

        //Класс исключения времени сборки
        public class CCSSettingsException : Exception
        {
            public CCSSettingsException()
                : base()
            { }

            public CCSSettingsException(string message)
                : base(message)
            { }

            public CCSSettingsException(string message, Exception innerException)
                : base(message, innerException)
            { }

            public CCSSettingsException(System.Runtime.Serialization.SerializationInfo info
                , System.Runtime.Serialization.StreamingContext context)
                : base(info, context)
            { }
        }
    }
}

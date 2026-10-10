namespace WolvenKit.Common.Services
{
    public enum SystemLogFlag
    {
        SLF_Default,
        SLF_Error,
        SLF_Warning,
        SLF_Info,
        SLF_Interpretable
    }

    public enum ToolLogFlag
    {
        TLF_Wcc,
        TLF_Radish,
    }

    public enum WccLogFlag
    {
        WLF_Default,
        WLF_Error,
        WLF_Warning,
        WLF_Info
    }

    public class LogStringEventArgs
    {
        #region Constructors

        public LogStringEventArgs(string message, LogType logType)
        {
            Message = message;
            LogType = logType;
        }

        #endregion Constructors

        #region Properties

        public LogType LogType { get; private set; }
        public string Message { get; private set; }

        #endregion Properties
    }
}

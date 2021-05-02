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

    public abstract class InterpretedLogMessage
    {
        #region Properties

        public string CommandName { get; set; }
        public WccLogFlag Flag { get; set; }
        public int Id { get; set; }

        // global flags
        public SystemLogFlag SystemFlag { get; set; }

        public ToolLogFlag Tool { get; set; }
        // Message

        public string Value { get; set; }

        #endregion Properties
    }

    /// <summary>
    /// Interpreted Wcc Log Messages
    /// </summary>
    public class RADLogMessage : InterpretedLogMessage
    {
    }

    /// <summary>
    /// Interpreted Wcc Log Messages
    /// </summary>
    public class WCCLogMessage : InterpretedLogMessage
    {
        #region Properties

        public string Timestamp { get; set; }
        public string WccModule { get; set; }

        #endregion Properties
    }

    public class LogStringEventArgs
    {
        #region Constructors

        public LogStringEventArgs(string message, Logtype logtype)
        {
            Message = message;
            Logtype = logtype;
        }

        #endregion Constructors

        #region Properties

        public Logtype Logtype { get; private set; }
        public string Message { get; private set; }

        #endregion Properties
    }
}

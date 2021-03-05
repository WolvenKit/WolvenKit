namespace WolvenKit.Common.WinFormsEnums
{
    public enum DialogResult
    {
        None,
        OK,
        Cancel,
        Abort,
        Retry,
        Ignore,
        Yes,
        No,
    }

    public enum MessageBoxButtons
    {
        OK,
        OKCancel,
        AbortRetryIgnore,
        YesNoCancel,
        YesNo,
        RetryCancel,
    }

    public enum MessageBoxIcon
    {
        None = 0,
        Error = 16, // 0x00000010
        Hand = 16, // 0x00000010
        Stop = 16, // 0x00000010
        Question = 32, // 0x00000020
        Exclamation = 48, // 0x00000030
        Warning = 48, // 0x00000030
        Asterisk = 64, // 0x00000040
        Information = 64, // 0x00000040
    }
}

namespace WolvenKit.App.Interaction;

public enum WMessageBoxImage
{
    None = 0,
    Hand = 1,
    Stop = 2,
    Error = 3,
    Question = 4,
    Exclamation = 5,
    Warning = 6,
    Asterisk = 7,
    Information = 8
}

public enum WMessageBoxButtons
{
    Ok,
    OkCancel,
    Yes,
    YesNo,
    YesNoCancel,
    No
}

public enum WMessageBoxResult
{
    None = 0,
    OK = 1,
    Cancel = 2,
    Yes = 3,
    No = 4,
    Custom = 5
}
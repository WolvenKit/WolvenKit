namespace WolvenKit.App.Interaction;

/// <summary>
/// Specifies the icon that is displayed by a message box.
/// </summary>
public enum WMessageBoxImage
{
    /// <summary>
    /// The message box contains no symbols.
    /// </summary>
    None = 0,

    /// <summary>
    /// The message box contains a symbol consisting of a white X in a circle with a red background.
    /// </summary>
    Hand = 1,

    /// <summary>
    /// The message box contains a symbol consisting of white X in a circle with a red background.
    /// </summary>
    Stop = 2,

    /// <summary>
    /// The message box contains a symbol consisting of white X in a circle with a red background.
    /// </summary>
    Error = 3,

    /// <summary>
    /// The message box contains a symbol consisting of a question mark in a circle.
    /// </summary>
    Question = 4,

    /// <summary>
    /// The message box contains a symbol consisting of an exclamation point in a triangle with a yellow background.
    /// </summary>
    Exclamation = 5,

    /// <summary>
    /// The message box contains a symbol consisting of an exclamation point in a triangle with a yellow background.
    /// </summary>
    Warning = 6,

    /// <summary>
    /// The message box contains a symbol consisting of a lowercase letter i in a circle.
    /// </summary>
    Asterisk = 7,

    /// <summary>
    /// The message box contains a symbol consisting of a lowercase letter i in a circle.
    /// </summary>
    Information = 8
}

/// <summary>
/// Specifies the buttons that are displayed on a message box.
/// </summary>
public enum WMessageBoxButtons
{
    /// <summary>
    /// The message box displays an OK button.
    /// </summary>
    Ok,

    /// <summary>
    /// The message box displays OK and Cancel buttons.
    /// </summary>
    OkCancel,

    /// <summary>
    /// The message box displays a Yes button.
    /// </summary>
    Yes,

    /// <summary>
    /// The message box displays Yes and No buttons.
    /// </summary>
    YesNo,

    /// <summary>
    /// The message box displays Yes, No, and Cancel buttons.
    /// </summary>
    YesNoCancel,

    /// <summary>
    /// The message box displays a No button.
    /// </summary>
    No
}

/// <summary>
/// Specifies which message box button that a user clicks.
/// </summary>
public enum WMessageBoxResult
{
    /// <summary>
    /// The message box returns no result.
    /// </summary>
    None = 0,

    /// <summary>
    /// The result value of the message box is OK.
    /// </summary>
    OK = 1,

    /// <summary>
    /// The result value of the message box is Cancel.
    /// </summary>
    Cancel = 2,

    /// <summary>
    /// The result value of the message box is Yes.
    /// </summary>
    Yes = 3,

    /// <summary>
    /// The result value of the message box is No.
    /// </summary>
    No = 4,

    /// <summary>
    /// ???
    /// </summary>
    Custom = 5
}
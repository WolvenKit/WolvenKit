namespace WolvenKit.Common;

public enum TemplateSource
{
    Auto,
    System,
    User
}

public enum TemplateDestination
{
    System,
    User
}

public enum RedTypeTemplateSelectionOptionSource
{
    User,
    System,
    Raw // Raw as in the default as defined by the RTTI
}

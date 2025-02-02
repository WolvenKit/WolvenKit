namespace WolvenKit.RED4.Types;

//public class DynamicBaseClass : RedBaseClass, IDynamicResource
//{
//    [REDProperty(IsIgnored = true)]
//    public string ClassName { get; set; }
//}

//public class DynamicResource : CResource, IDynamicResource
//{
//    [REDProperty(IsIgnored = true)]
//    public string ClassName { get; set; }
//}

//public interface DynamicRedClass
//{
//    public CName ClassName { get; set; }
//}

public class DynamicBaseClass : RedBaseClass, IDynamicClass
{
    //public string ClassName;
    [RED("className")]
    [REDProperty(IsIgnored = true)]
    public CName ClassName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }

    public T Convert<T>() where T : RedBaseClass
    {
        if (typeof(T) == typeof(inkIWidgetController))
        {
            return (T)(RedBaseClass)ToDynamicWidgetController();
        }
        else if (typeof(T) == typeof(inkWidgetLogicController))
        {
            return (T)(RedBaseClass)ToDynamicWidgetLogicController();
        }
        else
        {
            return default(T);
        }
    }

    public DynamicWidgetController ToDynamicWidgetController()
    {
        var dwc = new DynamicWidgetController();
        foreach (var prop in GetDynamicPropertyNames())
        {
            dwc.SetProperty(prop, GetProperty(prop));
        }
        dwc.ClassName = ClassName;
        return dwc;
    }

    public DynamicWidgetLogicController ToDynamicWidgetLogicController()
    {
        var dwc = new DynamicWidgetLogicController();
        foreach (var prop in GetDynamicPropertyNames())
        {
            dwc.SetProperty(prop, GetProperty(prop));
        }
        dwc.ClassName = ClassName;
        return dwc;
    }
}

public class DynamicResource : CResource, IDynamicResource
{
    [RED("className")]
    [REDProperty(IsIgnored = true)]
    public CName ClassName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }
}

public class DynamicWidgetController : inkIWidgetController, IDynamicClass
{
    [RED("className")]
    [REDProperty(IsIgnored = true)]
    public CName ClassName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }
}

public class DynamicWidgetLogicController : inkWidgetLogicController, IDynamicClass
{
    [RED("className")]
    [REDProperty(IsIgnored = true)]
    public CName ClassName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }
}

public class DynamicGraphNodeDefinition : graphGraphNodeDefinition, IDynamicClass
{
    [RED("className")]
    [REDProperty(IsIgnored = true)]
    public CName ClassName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }
}

public class DynamicSceneGraphNode : scnSceneGraphNode, IDynamicClass
{
    [RED("className")]
    [REDProperty(IsIgnored = true)]
    public CName ClassName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }
}
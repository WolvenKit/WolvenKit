namespace WolvenKit.RED4.Types;

public interface DynamicRedClass
{
    public CName ClassName { get; set; }
}

public class DynamicBaseClass : RedBaseClass, DynamicRedClass
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
        else if(typeof(T) == typeof(inkWidgetLogicController))
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

public class DynamicResource : CResource, DynamicRedClass
{
    [RED("className")]
    [REDProperty(IsIgnored = true)]
    public CName ClassName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }
}

public class DynamicWidgetController : inkIWidgetController, DynamicRedClass
{
    [RED("className")]
    [REDProperty(IsIgnored = true)]
    public CName ClassName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }
}

public class DynamicWidgetLogicController : inkWidgetLogicController, DynamicRedClass
{
    [RED("className")]
    [REDProperty(IsIgnored = true)]
    public CName ClassName
    {
        get => GetPropertyValue<CName>();
        set => SetPropertyValue<CName>(value);
    }
}

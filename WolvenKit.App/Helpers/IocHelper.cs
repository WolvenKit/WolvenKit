using System;


namespace WolvenKit.App.Helpers;
public static class IocHelper
{
    public static T GetService<T>() => (T)GetFunc(typeof(T));

    public static Func<Type, object> GetFunc { get; set; } = _ => throw new NotImplementedException();


}

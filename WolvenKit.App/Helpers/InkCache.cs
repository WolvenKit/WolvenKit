using System.Windows;

namespace WolvenKit.App.Helpers;

public static class InkCache
{
    private static ResourceDictionary? s_resourceDictionary;

    public static ResourceDictionary Resources
    {
        get
        {
            if (s_resourceDictionary == null)
            {
                s_resourceDictionary = new ResourceDictionary();
                Application.Current.Resources.MergedDictionaries.Add(s_resourceDictionary);
            }
            return s_resourceDictionary;
        }
    }
}
using WolvenKit.Core.Interfaces;

namespace WolvenKit.RED4.Types;

public static class TypeGlobal
{
    public static ILoggerService? Logger;

    public static bool OnParsingError(ParsingErrorEventArgs e)
    {
        if (e is InvalidDefaultValueEventArgs)
        {
            return true;
        }

        if (e is InvalidRTTIEventArgs e1)
        {
            if (e1.ExpectedType == typeof(redResourceReferenceScriptToken) && e1.ActualType == typeof(CString))
            {
                var orgStr = (string)(CString)e1.Value!;

                e1.Value = new redResourceReferenceScriptToken
                {
                    Resource = new CResourceAsyncReference<CResource>(orgStr)
                };

                Logger?.Warning($"Invalid in wolven rtti for \"{e1.PropertyName}\": [Expected: \"{e1.ExpectedType.Name}\" | Got: \"{e1.ActualType.Name}\"]");

                return true;
            }

            if (e1.ExpectedType == typeof(CResourceAsyncReference<inkWidgetLibraryResource>) &&
                e1.ActualType == typeof(CResourceReference<inkWidgetLibraryResource>))
            {
                var orgVal = (CResourceReference<inkWidgetLibraryResource>)e1.Value!;

                e1.Value = new CResourceAsyncReference<inkWidgetLibraryResource>(orgVal.DepotPath, orgVal.Flags);

                Logger?.Warning($"Invalid in wolven rtti for \"{e1.PropertyName}\": [Expected: \"{e1.ExpectedType.Name}\" | Got: \"{e1.ActualType.Name}\"]");

                return true;
            }

            if (e1.PropertyName == "SsimpleBanerData.content" &&
                e1.ExpectedType == typeof(redResourceReferenceScriptToken) && 
                e1.ActualType == typeof(ResourcePath))
            {
                var orgStr = (ResourcePath)e1.Value!;

                e1.Value = new redResourceReferenceScriptToken
                {
                    Resource = new CResourceAsyncReference<CResource>(orgStr)
                };

                Logger?.Warning($"Invalid in wolven rtti for \"{e1.PropertyName}\": [Expected: \"{e1.ExpectedType.Name}\" | Got: \"{e1.ActualType.Name}\"]");

                return true;
            }
        }

        if (e is InvalidEnumValueEventArgs e2)
        {
            if (System.Activator.CreateInstance(e2.EnumType) is not Enum value)
            {
                throw new Exception();
            }

            e2.Value = value;

            Logger?.Warning($"Unknown enum value found for type \"{e2.EnumType.Name}\": {e2.StringValue}");

            return true;
        }

        return false;
    }
}

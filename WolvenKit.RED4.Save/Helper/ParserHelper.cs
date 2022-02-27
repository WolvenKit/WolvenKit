using System.Reflection;

namespace WolvenKit.RED4.Save;

public class ParserHelper
{
    private static readonly Dictionary<string, Type> _parsers = new();
    private static bool _isLoaded;


    private static void LoadParsers()
    {
        var baseType = typeof(INodeParser);

        foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
        {
            if (!baseType.IsAssignableFrom(type))
            {
                continue;
            }

            var prop = type.GetProperty("NodeName", BindingFlags.Public | BindingFlags.Static);
            if (prop != null)
            {
                var name = (string)prop.GetValue(null, null)!;
                _parsers.Add(name, type);
            }
        }

        _isLoaded = true;
    }

    public static INodeParser? GetParser(string nodeName)
    {
        if (!_isLoaded)
        {
            LoadParsers();
        }

        // Just for debugging
        // var allowed = new List<string> { Constants.NodeNames.INVENTORY, Constants.NodeNames.ITEM_DATA };
        // if (!allowed.Contains(nodeName))
        // {
        //     return null;
        // }

        if (_parsers.ContainsKey(nodeName))
        {
            return (INodeParser)System.Activator.CreateInstance(_parsers[nodeName])!;
        }
        return null;
    }
}

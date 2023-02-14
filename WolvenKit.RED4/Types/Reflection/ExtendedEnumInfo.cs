using System.Reflection;

namespace WolvenKit.RED4.Types;

public class ExtendedEnumInfo
{
    public ExtendedEnumInfo(Type type)
    {
        Type = type;
        IsBitfield = type.GetCustomAttribute<FlagsAttribute>() != null;

        if (!IsBitfield)
        {
            var val = (Enum)System.Activator.CreateInstance(Type);
            if (val!.ToString() != "0")
            {
                DefaultValue = val.ToString();
            }
        }

        var valueNames = Enum.GetNames(Type);
        foreach (var valueName in valueNames)
        {
            Names.Add(valueName);

            if (!IsBitfield && DefaultValue == null && valueName == "None")
            {
                DefaultValue = "None";
            }

            var member = Type.GetMember(valueName);
            var redAttr = member[0].GetCustomAttribute<REDAttribute>();
            if (redAttr != null)
            {
                RedNames.Add(redAttr.Name, valueName);
            }
        }

        if (!IsBitfield && DefaultValue == null)
        {
            // TODO
        }
    }

    public Type Type { get; set; }
    public bool IsBitfield { get; set; }

    public List<string> Names { get; set; } = new();
    public Dictionary<string, string> RedNames { get; set; } = new();

    public string? DefaultValue { get; set; }

    public string? GetCSNameFromRedName(string valueName)
    {
        if (Names.Contains(valueName))
        {
            return valueName;
        }

        if (RedNames.ContainsKey(valueName))
        {
            return RedNames[valueName];
        }

        return null;
    }

    public string GetRedNameFromCSName(string valueName)
    {
        if (RedNames.ContainsValue(valueName))
        {
            return RedNames.FirstOrDefault(x => x.Value == valueName).Key;
        }

        return valueName;
    }
}
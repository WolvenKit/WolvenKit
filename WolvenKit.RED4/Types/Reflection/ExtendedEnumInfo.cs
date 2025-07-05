using System.Reflection;

namespace WolvenKit.RED4.Types;

public class ExtendedEnumInfo
{
    public ExtendedEnumInfo(Type type)
    {
        Type = type;
        IsBitfield = type.GetCustomAttribute<FlagsAttribute>() != null;

        RedName = type.Name;
        var redAttr = type.GetCustomAttribute<REDAttribute>();
        if (redAttr != null)
        {
            RedName = redAttr.Name;
        }

        if (!IsBitfield)
        {
            var val = (Enum)System.Activator.CreateInstance(Type)!;
            if (val.ToString() != "0")
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
            var redAttr2 = member[0].GetCustomAttribute<REDAttribute>();
            if (redAttr2 != null)
            {
                RedNames.Add(redAttr2.Name, valueName);
            }
        }

        if (!IsBitfield && DefaultValue == null)
        {
            // TODO
        }
    }

    public Type Type { get; set; }
    public bool IsBitfield { get; set; }

    public string RedName { get; set; }

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
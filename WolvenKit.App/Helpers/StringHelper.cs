using System.Collections.Generic;
using System.Linq;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Helpers;

public class StringHelper
{
    public static string Stringify(CArray<scnOutputSocket> scnOutputAry)
    {
        if (scnOutputAry.Count == 0)
        {
            return "";
        }

        var nodeIds = scnOutputAry.Select(
            (scnOutput) => Stringify(
                scnOutput.Destinations.Select((dest) => dest.NodeId.Id.ToString() ?? "")
                    .Where(s => s != "").ToArray()
            )
        ).ToArray();
        return Stringify(nodeIds);
    }

    public static string Stringify(Vector4 vector4)
    {
        if (vector4.X == 0 && vector4.Y == 0 && vector4.Z == 0)
        {
            return "";
        }

        return $"{vector4.X}, {vector4.Y}, {vector4.Z}, {vector4.W}";
    }

    public static string Stringify(ICollection<TweakDBID> tweakDbIdCollection)
    {
        if (tweakDbIdCollection.Count == 0)
        {
            return "";
        }

        return $"[ {string.Join(", ",
            tweakDbIdCollection.ToList().Select(t => t.GetResolvedText() ?? "").Where((item) => item != "").ToArray())} ]";
    }

    public static string Stringify(entHardTransformBinding hardTransformBinding)
    {
        var ret = $"{hardTransformBinding.SlotName}".Replace("None", "");
        if (ret == "")
        {
            ret = $"{hardTransformBinding.BindName}".Replace("None", "");
        }

        return ret;
    }

    public static string Stringify(ICollection<CName> cNameCollection)
    {
        if (cNameCollection.Count == 0)
        {
            return "";
        }

        return $"[ {string.Join(", ",
            cNameCollection.ToList().Select(t => t.GetResolvedText() ?? "").Where((item) => item != "").ToArray())} ]";
    }

    public static string Stringify(string[] stringCollection)
    {
        stringCollection = stringCollection.Where(item => item != "").ToArray();
        if (stringCollection.Length == 0)
        {
            return "";
        }

        return $"[{string.Join(", ", stringCollection)}]";
    }
}
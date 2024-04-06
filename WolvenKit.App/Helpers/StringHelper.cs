using System.Collections.Generic;
using System.Linq;
using WolvenKit.App.Helpers.StringHelpers;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Helpers;

public static class StringHelper
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

    public static string Stringify(CArray<CResourceAsyncReference<animAnimSet>> animSets, bool getFilenameOnly = false)
    {
        if (animSets.Count == 0)
        {
            return "";
        }

        var paths = animSets
            .Select((animRef) => animRef.DepotPath.GetResolvedText() ?? "")
            .Where((text) => text != "")
            .Select(text => !getFilenameOnly ? text : text.Split('\\').LastOrDefault() ?? text)
            .ToList();
        return $"[ {string.Join(", ", paths)} ]";
    }

    public static string Stringify(CColor color)
    {
        var ret = $"R: {color.Red}, G: {color.Green}, B: {color.Blue}";
        return color.Alpha == 1 ? ret : $"{ret}, A: {color.Alpha}";
    }


    public static string Stringify(ResourcePath? depotPath, bool getFilenameOnly = false) =>
        StringifyOrNull(depotPath, getFilenameOnly) ?? "";

    public static string? StringifyOrNull(ResourcePath? depotPath, bool getFilenameOnly = false)
    {
        if (depotPath?.GetResolvedText() is not string path || path == "")
        {
            return null;
        }

        if (getFilenameOnly)
        {
            return path.Split("\\").LastOrDefault() ?? path;
        }

        return path;
    }

    public static string? StringifyOrNull(CName cname)
    {
        if (cname.GetResolvedText() is not string path || path == "")
        {
            return null;
        }

        return cname.GetResolvedText();
    }

    public static string Stringify(WorldTransform bind) =>
        $"Pos: (X: {(float)bind.Position.X:G9}, Y: {(float)bind.Position.Y:G9}, Z: {(float)bind.Position.Z:G9}), Orientation: ({bind.Orientation})";

    public static string Stringify(WorldPosition position) => $"{(float)position.X:G9}, {(float)position.Y:G9}, {(float)position.Z:G9}";

    public static string Stringify(worldNode? worldNode, bool asValue = false) => StringHelperWorldNode.Stringify(worldNode, asValue);

    public static string Stringify(animAnimNode_Base node, bool asValue = false) => StringHelperAnimNode.Stringify(node, asValue);
    public static string Stringify(redTagList tagList) => Stringify(tagList.Tags);

    public static string StringifyMeshAppearance(CResourceAsyncReference<CMesh> mesh, CName? meshAppearance)
    {
        var ret = mesh.DepotPath.GetResolvedText() ?? "";
        if (meshAppearance?.GetResolvedText() is not string s || s == "" || s == "default")
        {
            return ret;
        }

        return $"{ret} ({s})";
    }

    public static string? GetNodeName(CWeakHandle<animAnimNode_Base> linkNode) => StringHelperAnimNode.GetNodeName(linkNode);
}
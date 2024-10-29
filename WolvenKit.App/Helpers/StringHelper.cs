using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using WolvenKit.App.Helpers.StringHelpers;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Helpers;

public abstract partial class StringHelper
{
    public static string Stringify(CArray<scnOutputSocket> scnOutputAry)
    {
        if (scnOutputAry.Count == 0)
        {
            return "";
        }

        var nodeIds = scnOutputAry.Select(
            scnOutput => Stringify(
                scnOutput.Destinations.Select(dest => dest.NodeId.Id.ToString())
                    .Where(s => s != "").ToArray()
            )
        ).ToArray();
        return Stringify(nodeIds);
    }

    public static string Stringify(Vector4 vec, bool defaultIsOne = false)
    {
        var val = defaultIsOne ? 1 : 0;
        if (EqualsFloat(vec.X, val) && EqualsFloat(vec.Y, val) && EqualsFloat(vec.Z, val) && EqualsFloat(vec.W, 1))
        {
            return "";
        }

        return $"{vec.X}, {vec.Y}, {vec.Z}, {vec.W}";
    }


    private static string Stringify(Quaternion quat, bool defaultIsOne = false)
    {
        var val = defaultIsOne ? 1 : 0;
        if (EqualsFloat(quat.I, val) && EqualsFloat(quat.J, val) && EqualsFloat(quat.K, val) && EqualsFloat(quat.R, 1))
        {
            return "";
        }

        return $"{quat.I}, {quat.J}, {quat.K}, {quat.R}";
    }

    public static string Stringify(ICollection<TweakDBID> tweakDbIdCollection)
    {
        if (tweakDbIdCollection.Count == 0)
        {
            return "";
        }

        return $"[ {Stringify(tweakDbIdCollection.ToList().Select(t => t.GetResolvedText() ?? "").ToArray())} ]";
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

        return $"[ {Stringify(cNameCollection.ToList().Select(t => t.GetResolvedText() ?? "").ToArray())} ]";
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
            .Select(animRef => animRef.DepotPath.GetResolvedText() ?? "")
            .Where(text => text != "")
            .Select(text => !getFilenameOnly ? text : text.Split('\\').LastOrDefault() ?? text)
            .ToList();
        return $"[ {string.Join(", ", paths)} ]";
    }

    public static string Stringify(CColor color)
    {
        var ret = $"R: {color.Red}, G: {color.Green}, B: {color.Blue}";
        return color.Alpha == 255 ? ret : $"{ret}, A: {color.Alpha}";
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

    /// <summary>
    /// Regular expression to match archiveXL wildcards in appearance names, such as *{variant}
    /// Matches everything preceded by *{ followed by }$
    /// </summary>
    [GeneratedRegex(@"(?<=\*\{).*(?=\}$)")]
    private static partial Regex s_archiveXLPropertyRegex();
    
    public static string StringifyMeshAppearance(CResourceAsyncReference<CMesh> mesh, CName? meshAppearance)
    {
        var ret = Stringify(mesh.DepotPath);
        if (meshAppearance?.GetResolvedText() is not string s || s == "" || s == "default")
        {
            return ret;
        }

        // The whole appearance name is an ArchiveXL dynamic variant
        if (s_archiveXLPropertyRegex().Match(s) is { Success: true } m)
        {
            return ret + " {" + m.Groups[0].Value + "}";
        }

        // The appearance name contains dynamic variants
        if (s.StartsWith('*'))
        {
            s = s.Replace("*", "");
        }

        return $"{ret} [ {s} ]";
    }

    public static string? GetNodeName(CWeakHandle<animAnimNode_Base> linkNode) => StringHelperAnimNode.GetNodeName(linkNode);


    // rotation, scale, translation
    public static string Stringify(QsTransform qsTransform)
    {
        var rotation = Stringify(qsTransform.Rotation);
        var scale = Stringify(qsTransform.Scale, true);
        var translation = Stringify(qsTransform.Translation, true);

        List<string> values = [];

        if (rotation != "")
        {
            values.Add($"rot({rotation})");
        }

        if (scale != "")
        {
            values.Add($"scale({scale})");
        }

        if (translation != "")
        {
            values.Add($"translation({translation})");
        }

        return string.Join(", ", values);
    }

    private static bool EqualsFloat(float a, float b) => Math.Abs(a - b) < float.Epsilon;

}
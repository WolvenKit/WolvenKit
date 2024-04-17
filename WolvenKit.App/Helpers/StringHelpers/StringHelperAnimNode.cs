using System.Linq;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Helpers.StringHelpers;

internal static class StringHelperAnimNode
{
    public static string? GetNodeName(CWeakHandle<animAnimNode_Base>? linkNode)
    {
        if (linkNode is null)
        {
            return null;
        }

        if (linkNode.GetValue() is animAnimNode_Base node)
        {
            return GetNodeName(node);
        }

        if (linkNode.InnerType is { Name: not null })
        {
            return linkNode.InnerType.Name.Split("_").LastOrDefault();
        }

        return null;
    }

    private static string? GetNodeName(animAnimNode_Base? linkNode)
    {
        if (linkNode is null)
        {
            return null;
        }

        if (linkNode.GetType() is { Name: not null } t)
        {
            return t.Name.Split("_").LastOrDefault();
        }

        return "";
    }


    public static string Stringify(animAnimNode_Base? animNode, bool stringifyValue = false)
    {
        if (stringifyValue)
        {
            return StringifyValue(animNode);
        }

        return animNode?.DebugName.GetResolvedText() ?? "";
    }


    private static string StringifyValue(animAnimNode_Base? animNode) => animNode switch
    {
        animAnimNode_Output { Node: animPoseLink link } => GetNodeName(link.Node) ?? "",
        _ => ""
    };
}
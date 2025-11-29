using WolvenKit.App.ViewModels.GraphEditor;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Services;

/// <summary>
/// In-memory clipboard manager for copying and pasting nodes across graph files
/// </summary>
public static class GraphClipboardManager
{
    private static IRedType? _copiedNodeData;
    private static RedGraphType _sourceGraphType;

    /// <summary>
    /// Copies a node's data to the clipboard
    /// </summary>
    public static void CopyNode(NodeViewModel node, RedGraphType graphType)
    {
        if (node.Data is not IRedCloneable cloneable)
        {
            return;
        }

        // Deep copy the node data to clipboard
        _copiedNodeData = (IRedType)cloneable.DeepCopy();
        _sourceGraphType = graphType;
    }

    /// <summary>
    /// Checks if a node can be pasted into the specified graph type
    /// </summary>
    public static bool CanPaste(RedGraphType targetGraphType)
    {
        if (_copiedNodeData == null)
        {
            return false;
        }

        // Same-type paste always works
        if (_sourceGraphType == targetGraphType)
        {
            return true;
        }

        // Quest -> Scene: wrap quest node in scnQuestNode except phase and scene nodes
        if (_sourceGraphType == RedGraphType.Quest && 
            targetGraphType == RedGraphType.Scene &&
            _copiedNodeData is questNodeDefinition)
        {
            if (_copiedNodeData is questPhaseNodeDefinition)
            {
                return false;
            }
            
            if (_copiedNodeData is questSceneNodeDefinition)
            {
                return false;
            }
            
            return true;
        }

        // Scene -> Quest: ONLY allow scnQuestNode (unwrap it)
        if (_sourceGraphType == RedGraphType.Scene && 
            targetGraphType == RedGraphType.Quest &&
            _copiedNodeData is scnQuestNode)
        {
            return true;
        }

        return false;
    }

    /// <summary>
    /// Gets the copied node data for pasting
    /// </summary>
    public static IRedType? GetCopiedData()
    {
        return _copiedNodeData;
    }

    /// <summary>
    /// Gets the source graph type of the copied node
    /// </summary>
    public static RedGraphType GetSourceGraphType()
    {
        return _sourceGraphType;
    }

    /// <summary>
    /// Clears the clipboard
    /// </summary>
    public static void Clear()
    {
        _copiedNodeData = null;
    }

    /// <summary>
    /// Checks if clipboard has data
    /// </summary>
    public static bool HasData()
    {
        return _copiedNodeData != null;
    }
}

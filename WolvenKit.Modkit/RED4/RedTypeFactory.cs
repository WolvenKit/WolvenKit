using System;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;


namespace WolvenKit.Modkit.RED4;

/// <summary>
/// Some properties are uninitialized, despite the type specifying them as non-nullable.
/// This factory will make sure that they have valid default values. 
/// </summary>
public static class RedTypeFactory
{
    public static RedBaseClass CreateAndInit(Type type) => Init(RedTypeManager.Create(type));
    public static RedBaseClass CreateAndInit(string redTypeName) => Init(RedTypeManager.Create(redTypeName));

    public static IRedType CreateAndInitRedType(Type type, params object[] args) =>
        Init(RedTypeManager.CreateRedType(type, args));

    public static IRedType CreateAndInitRedType(string redTypeName, params object[] args) =>
        Init(RedTypeManager.CreateRedType(redTypeName, args));


// ReSharper disable NullCoalescingConditionIsAlwaysNotNullAccordingToAPIContract
    private static T Init<T>(T obj) where T : IRedType
    {
        switch (obj)
        {
            case CMaterialInstance matInstance:
                matInstance.Values ??= [];
                break;
            case appearanceAppearanceDefinition appDef:
                appDef.Components ??= [];
                break;
            case entEntityTemplate entTemplate:
                entTemplate.Entity ??= Init(new CHandle<entEntity>());
                entTemplate.Components ??= [];
                break;
            case questJournalNodeDefinition nodeDef:
                nodeDef.Type ??= Init(new CHandle<questIJournal_NodeType>());
                break;
            case questUIManagerNodeDefinition questUiNode:
                questUiNode.Type ??= Init(new CHandle<questIUIManagerNodeType>());
                break;
            case questShowPopup_NodeSubType subType:
                subType.Path ??= Init(new CHandle<gameJournalPath>());
                subType.Path.Chunk ??= Init(new gameJournalPath());
                break;
            case questJournalQuestEntry_NodeType questNode:
                questNode.Path ??= Init(new CHandle<gameJournalPath>());
                questNode.Path.Chunk ??= Init(new gameJournalPath());
                break;
            case CHandle<RedBaseClass> baseHandle:
                return (T)(IRedType)InitHandle(baseHandle);
            default:
                break;
        }

        return obj;
    }

    private static CHandle<T> InitHandle<T>(CHandle<T> handle) where T : RedBaseClass
    {
        handle.Chunk ??= CreateAndInit(typeof(T)) as T;
        return handle;
    }
}
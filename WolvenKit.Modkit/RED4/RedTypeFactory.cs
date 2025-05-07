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
            case questShowPopup_NodeSubType subType:
                subType.Path ??= Init(new CHandle<gameJournalPath>());
                subType.Path.Chunk ??= Init(new gameJournalPath());
                break;
            case questOpenBriefing_NodeType openBriefingNode:
                openBriefingNode.BriefingPath ??= Init(new CHandle<gameJournalPath>());
                openBriefingNode.BriefingPath.Chunk ??= Init(new gameJournalPath());
                break;
            case questJournalBulkUpdate_NodeType journalBulkUpdateNodeNode:
                journalBulkUpdateNodeNode.Path ??= Init(new CHandle<gameJournalPath>());
                journalBulkUpdateNodeNode.Path.Chunk ??= Init(new gameJournalPath());
                break;
            case questJournalChangeMappinPhase_NodeType journalChangeMappinPhaseNode:
                journalChangeMappinPhaseNode.Path ??= Init(new CHandle<gameJournalPath>());
                journalChangeMappinPhaseNode.Path.Chunk ??= Init(new gameJournalPath());
                break;
            case questJournalContact_NodeType journalContactNodeType:
                journalContactNodeType.Path ??= Init(new CHandle<gameJournalPath>());
                journalContactNodeType.Path.Chunk ??= Init(new gameJournalPath());
                break;
            case questJournalEntry_NodeType journalEntryNode:
                journalEntryNode.Path ??= Init(new CHandle<gameJournalPath>());
                journalEntryNode.Path.Chunk ??= Init(new gameJournalPath());
                break;
            case questJournalPushPopQuestObjective_NodeType journalPushPopQuestObjectiveNode:
                journalPushPopQuestObjectiveNode.Path ??= Init(new CHandle<gameJournalPath>());
                journalPushPopQuestObjectiveNode.Path.Chunk ??= Init(new gameJournalPath());
                break;
            case questJournalQuestEntry_NodeType journalQuestEntryNodeNode:
                journalQuestEntryNodeNode.Path ??= Init(new CHandle<gameJournalPath>());
                journalQuestEntryNodeNode.Path.Chunk ??= Init(new gameJournalPath());
                break;
            case questJournalQuestObjectiveCounter_NodeType journalQuestObjectiveCounterNode:
                journalQuestObjectiveCounterNode.Path ??= Init(new CHandle<gameJournalPath>());
                journalQuestObjectiveCounterNode.Path.Chunk ??= Init(new gameJournalPath());
                break;
            case questJournalQuestSetObjectiveOptional_NodeType journalQuestSetObjectiveOptionalNode:
                journalQuestSetObjectiveOptionalNode.Path ??= Init(new CHandle<gameJournalPath>());
                journalQuestSetObjectiveOptionalNode.Path.Chunk ??= Init(new gameJournalPath());
                break;
            case questJournalSetLockQuestObjective_NodeType journalSetLockQuestObjectiveNode:
                journalSetLockQuestObjectiveNode.Path ??= Init(new CHandle<gameJournalPath>());
                journalSetLockQuestObjectiveNode.Path.Chunk ??= Init(new gameJournalPath());
                break;
            case questJournalTrackQuest_NodeType journalTrackQuestNode:
                journalTrackQuestNode.Path ??= Init(new CHandle<gameJournalPath>());
                journalTrackQuestNode.Path.Chunk ??= Init(new gameJournalPath());
                break;
            case questJournalEntryState_ConditionType journalEntryStateCondition:
                journalEntryStateCondition.Path ??= Init(new CHandle<gameJournalPath>());
                journalEntryStateCondition.Path.Chunk ??= Init(new gameJournalPath());
                break;
            case questJournalEntryVisited_ConditionType journalEntryVisitedCondition:
                journalEntryVisitedCondition.Path ??= Init(new CHandle<gameJournalPath>());
                journalEntryVisitedCondition.Path.Chunk ??= Init(new gameJournalPath());
                break;
            case questJournalEntry_ConditionType journalEntryCondition:
                journalEntryCondition.Path ??= Init(new CHandle<gameJournalPath>());
                journalEntryCondition.Path.Chunk ??= Init(new gameJournalPath());
                break;
            case questMappinState_ConditionType mappinStateCondition:
                mappinStateCondition.MappinPath ??= Init(new CHandle<gameJournalPath>());
                mappinStateCondition.MappinPath.Chunk ??= Init(new gameJournalPath());
                break;
            case questChangeContactList_NodeTypeParams changeContactListNodeParams:
                changeContactListNodeParams.Contact ??= Init(new CHandle<gameJournalPath>());
                changeContactListNodeParams.Contact.Chunk ??= Init(new gameJournalPath());
                break;
            case questCallContact_NodeType callContactNode:
                callContactNode.Addressee ??= Init(new CHandle<gameJournalPath>());
                callContactNode.Addressee.Chunk ??= Init(new gameJournalPath());
                callContactNode.Caller ??= Init(new CHandle<gameJournalPath>());
                callContactNode.Caller.Chunk ??= Init(new gameJournalPath());
                break;
            case questCloseMessage_NodeType closeMessageNode:
                closeMessageNode.Msg ??= Init(new CHandle<gameJournalPath>());
                closeMessageNode.Msg.Chunk ??= Init(new gameJournalPath());
                break;
            case questOpenMessage_NodeType openMessageNode:
                openMessageNode.Msg ??= Init(new CHandle<gameJournalPath>());
                openMessageNode.Msg.Chunk ??= Init(new gameJournalPath());
                break;
            case questSendMessage_NodeType sendMessageNode:
                sendMessageNode.Msg ??= Init(new CHandle<gameJournalPath>());
                sendMessageNode.Msg.Chunk ??= Init(new gameJournalPath());
                break;
            case questMappinManagerNodeDefinition mappinManagerNode:
                mappinManagerNode.Path ??= Init(new CHandle<gameJournalPath>());
                mappinManagerNode.Path.Chunk ??= Init(new gameJournalPath());
                break;
            case questMappinGPSDistance questMappinGpsDistance:
                questMappinGpsDistance.MappinPath ??= Init(new CHandle<gameJournalPath>());
                questMappinGpsDistance.MappinPath.Chunk ??= Init(new gameJournalPath());
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
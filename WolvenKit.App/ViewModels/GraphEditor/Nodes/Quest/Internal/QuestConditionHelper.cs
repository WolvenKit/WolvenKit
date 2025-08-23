using System.Collections.Generic;
using System.Linq;
using WolvenKit.RED4.Types;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.App.ViewModels.GraphEditor.Nodes.Quest.Internal;

public class QuestConditionHelper
{
    public static (string suffix, Dictionary<string, string> details) GetDetails(questIBaseCondition data)
    {
        var suffix = "";
        var details = new Dictionary<string, string>();

        if (data is questTriggerCondition triggerCondition)
        {
            details.Add("Trigger Area", triggerCondition.TriggerAreaRef.GetResolvedText()!);
            details.Add("Type", triggerCondition.Type.ToEnumString());
        }

        if (data is questObjectCondition objectCondition && objectCondition.Type.Chunk is questDevice_ConditionType deviceCondition)
        {
            details.Add("Object", deviceCondition.ObjectRef.GetResolvedText()!);
            details.Add("Class", deviceCondition.DeviceControllerClass.GetResolvedText()!);
            details.Add("Function", deviceCondition.DeviceConditionFunction.GetResolvedText()!);
        }

        if (data is questFactsDBCondition factsDbCondition && factsDbCondition.Type.Chunk is questVarComparison_ConditionType varComparisonCondition)
        {
            suffix = " - Compare";
            details.Add("Name", varComparisonCondition.FactName);
            details.Add("Comparison", varComparisonCondition.ComparisonType.ToEnumString());
            details.Add("Value", varComparisonCondition.Value.ToString());
        }

        if (data is questSpawnerCondition spawnerCondition && spawnerCondition.Type.Chunk is questSpawnerReady_ConditionType spawnerReadyCondition)
        {
            suffix = " - Is Ready";
            details.Add("Reference", spawnerReadyCondition.SpawnerReference.GetResolvedText()!);
        }

        if (data is questCharacterCondition characterCondition && characterCondition.Type.Chunk is questCharacterMount_ConditionType characterMountCondition)
        {
            suffix = " - Is Mounted";
            details.Add("Parent Ref", ParseGameEntityReference(characterMountCondition.ParentRef));
        }

        return (suffix, details);
    }

    /// <summary>
    /// Creates a human-readable semantic description of a condition
    /// </summary>
    public static Dictionary<string, string> GetSemanticConditionDisplay(questIBaseCondition? condition)
    {
        var details = new Dictionary<string, string>();
        
        if (condition == null)
        {
            details["Type"] = "None";
            details["Condition"] = "None";
            return details;
        }

        // Always add the condition type as the first line
        var conditionTypeName = GetDetailedConditionTypeName(condition);
        details["Type"] = conditionTypeName;

        // Handle logical conditions with multiple sub-conditions using list format
        if (condition is questLogicalCondition logical && logical.Conditions?.Count > 1)
        {
            var operation = logical.Operation.ToString().ToUpper();
            details["Condition"] = $"{operation} of {logical.Conditions.Count} conditions";
            
            // Add individual conditions as separate detail lines (up to 15)
            var validConditions = logical.Conditions.Where(c => c?.Chunk != null).Take(15).ToList();
            for (int i = 0; i < validConditions.Count; i++)
            {
                var condDesc = FormatConditionSemantically(validConditions[i].Chunk!);
                var condTypeName = GetDetailedConditionTypeName(validConditions[i].Chunk!);
                details[$"#{i + 1} {condTypeName}"] = condDesc;
            }
            
            if (logical.Conditions.Count > 15)
            {
                details["..."] = $"+ {logical.Conditions.Count - 15} more conditions";
            }
        }
        else
        {
            var description = FormatConditionSemantically(condition);
            if (!string.IsNullOrEmpty(description))
            {
                details["Condition"] = description;
            }
            else
            {
                // Fallback to type name if we can't format it semantically
                details["Condition"] = conditionTypeName;
            }
        }

        return details;
    }

    private static string FormatConditionSemantically(questIBaseCondition condition)
    {
        return condition switch
        {
            questTriggerCondition trigger => FormatTriggerCondition(trigger),
            questFactsDBCondition facts => FormatFactsCondition(facts),
            questObjectCondition obj => FormatObjectCondition(obj),
            questTimeCondition time => FormatTimeCondition(time),
            questCharacterCondition character => FormatCharacterCondition(character),
            questDistanceCondition distance => FormatDistanceCondition(distance),
            questLogicalCondition logical => FormatLogicalCondition(logical),
            questSceneCondition scene => FormatSceneCondition(scene),
            questJournalCondition journal => FormatJournalCondition(journal),
            questSystemCondition system => FormatSystemCondition(system),
            questVehicleCondition vehicle => FormatVehicleCondition(vehicle),
            questUICondition ui => FormatUICondition(ui),
            questStatsCondition stats => FormatStatsCondition(stats),
            questSpawnerCondition spawner => FormatSpawnerCondition(spawner),
            questSensesCondition senses => FormatSensesCondition(senses),
            questPaymentCondition payment => FormatPaymentCondition(payment),
            questEntityCondition entity => FormatEntityCondition(entity),
            questContentCondition content => FormatContentCondition(content),
            _ => $"{condition.GetType().Name.Replace("quest", "").Replace("Condition", "")} condition"
        };
    }

    private static string FormatTriggerCondition(questTriggerCondition trigger)
    {
        var actor = trigger.IsPlayerActivator ? "Player" : "Actor";
        var area = trigger.TriggerAreaRef.GetResolvedText();
        var action = trigger.Type.ToString();
        
        return $"{actor} {action} {area}";
    }

    private static string FormatFactsCondition(questFactsDBCondition facts)
    {
        if (facts.Type?.Chunk is questVarComparison_ConditionType varComp)
        {
            var op = MapComparisonOperator((object)varComp.ComparisonType);
            return $"{varComp.FactName} {op} {varComp.Value}";
        }
        else if (facts.Type?.Chunk is questVarVsVarComparison_ConditionType varVsVar)
        {
            var op = MapComparisonOperator((object)varVsVar.ComparisonType);
            return $"{varVsVar.FactName1} {op} {varVsVar.FactName2}";
        }
        return "Facts condition";
    }

    private static string FormatObjectCondition(questObjectCondition obj)
    {
        if (obj.Type?.Chunk is questDevice_ConditionType device)
        {
            var objectRef = device.ObjectRef.GetResolvedText();
            var function = device.DeviceConditionFunction.GetResolvedText();
            var controllerClass = device.DeviceControllerClass.GetResolvedText();
            return $"{objectRef} ({controllerClass}) {function}";
        }
        else if (obj.Type?.Chunk is questInventory_ConditionType inventory)
        {
            var target = inventory.IsPlayer ? "Player" : ParseGameEntityReference(inventory.ObjectRef);
            var item = !string.IsNullOrEmpty(inventory.ItemID.GetResolvedText()) 
                ? inventory.ItemID.GetResolvedText() 
                : inventory.ItemTag.GetResolvedText();
            var op = MapComparisonOperator((object)inventory.ComparisonType);
            return $"{target} {op} {inventory.Quantity} {item}";
        }
        return "Object condition";
    }

    private static string FormatTimeCondition(questTimeCondition time)
    {
        if (time.Type?.Chunk is questRealtimeDelay_ConditionType realtime)
        {
            var totalMs = (realtime.Hours * 3600 + realtime.Minutes * 60 + realtime.Seconds) * 1000 + realtime.Miliseconds;
            if (totalMs < 1000)
                return $"Wait {realtime.Miliseconds}ms";
            else if (totalMs < 60000)
                return $"Wait {realtime.Seconds}s";
            else if (totalMs < 3600000)
                return $"Wait {realtime.Minutes}m {realtime.Seconds}s";
            else
                return $"Wait {realtime.Hours}h {realtime.Minutes}m";
        }
        else if (time.Type?.Chunk is questGameTimeDelay_ConditionType gametime)
        {
            if (gametime.Days > 0)
                return $"Wait {gametime.Days}d {gametime.Hours}h";
            else if (gametime.Hours > 0)
                return $"Wait {gametime.Hours}h {gametime.Minutes}m";
            else
                return $"Wait {gametime.Minutes}m {gametime.Seconds}s";
        }
        else if (time.Type?.Chunk is questTickDelay_ConditionType tick)
        {
            return $"Wait {tick.TickCount} ticks";
        }
        else if (time.Type?.Chunk is questTimePeriod_ConditionType timePeriod)
        {
            return FormatTimePeriodCondition(timePeriod);
        }
        return "Time condition";
    }

    private static string FormatCharacterCondition(questCharacterCondition character)
    {
        return character.Type?.Chunk switch
        {
            questCharacterBodyType_CondtionType bodyType => 
                $"{(bodyType.IsPlayer ? "Player" : ParseGameEntityReference(bodyType.ObjectRef))} is {bodyType.Gender}",
            
            questCharacterSpawned_ConditionType spawned => 
                FormatCharacterSpawnedCondition(spawned),
            
            questCharacterMount_ConditionType mount => 
                FormatMountCondition(mount),
            
            questCharacterHit_ConditionType hit => 
                $"{(hit.IsAttackerPlayer ? "Player" : ParseGameEntityReference(hit.AttackerRef))} hits {(hit.IsTargetPlayer ? "Player" : ParseGameEntityReference(hit.TargetRef))}",
            
            questCharacterHealth_ConditionType health => 
                $"{(health.IsPlayer ? "Player" : ParseGameEntityReference(health.ObjectRef))} health {MapComparisonOperator((object)health.ComparisonType)} {health.Percent}%",
            
            questCharacterStatPool_ConditionType statPool => 
                $"{(statPool.IsPlayer ? "Player" : ParseGameEntityReference(statPool.ObjectRef))} {statPool.StatPoolType} {MapComparisonOperator((object)statPool.ComparisonType)} {statPool.Percent}%",
            
            questCharacterStatusEffect_CondtionType statusEffect => 
                $"{(statusEffect.IsPlayer ? "Player" : ParseGameEntityReference(statusEffect.ObjectRef))} {(statusEffect.Inverted ? "does not have " : "has ")}{statusEffect.StatusEffectID}",
            
            questCharacterCombat_ConditionType combat => 
                $"{(combat.IsPlayer ? "Player" : ParseGameEntityReference(combat.ObjectRef))} {(combat.Inverted ? "not in" : "in")} combat",
            
            questCharacterState_ConditionType state => 
                FormatCharacterStateCondition(state),
            
            questCharacterKilled_ConditionType killed => 
                FormatCharacterKilledCondition(killed),
            
            questCharacterWorkspot_ConditionType workspot => 
                FormatCharacterWorkspotCondition(workspot),
            
            questCharacterAim_ConditionType aim => 
                FormatCharacterAimCondition(aim),
            
            questCharacterAppearancePrefetched_ConditionType appearance => 
                FormatCharacterAppearanceCondition(appearance),
            
            questCharacterAttack_ConditionType attack => 
                FormatCharacterAttackCondition(attack),
            
            questCharacterCallReinforcements_ConditionType reinforcements => 
                FormatCharacterCallReinforcementsCondition(reinforcements),
            
            questCharacterControlledObjectHit_ConditionType controlledHit => 
                FormatCharacterControlledObjectHitCondition(controlledHit),
            
            questCharacterCover_ConditionType cover => 
                FormatCharacterCoverCondition(cover),
            
            questCharacterCyberdeckProgram_ConditionType cyberdeck => 
                FormatCharacterCyberdeckProgramCondition(cyberdeck),
            
            questCharacterEquippedItem_ConditionType equippedItem => 
                FormatCharacterEquippedItemCondition(equippedItem),
            
            questCharacterEquippedWeapon_ConditionType equippedWeapon => 
                FormatCharacterEquippedWeaponCondition(equippedWeapon),
            
            questCharacterLifePath_ConditionType lifePath => 
                FormatCharacterLifePathCondition(lifePath),

            questCharacterMountedTogether_ConditionType mountedTogether =>
                FormatCharacterMountedTogetherCondition(mountedTogether),

            questCharacterReaction_ConditionType reaction =>
                FormatCharacterReactionCondition(reaction),

            questCharacterRoleFinished_ConditionType roleFinished =>
                FormatCharacterRoleFinishedCondition(roleFinished),

            questCharacterQuickHacked_ConditionType quickHacked =>
                FormatCharacterQuickHackedCondition(quickHacked),

            questCharacterQuickHackUploadBegin_ConditionType quickHackUploadBegin =>
                FormatCharacterQuickHackUploadBeginCondition(quickHackUploadBegin),
            
            _ => $"Character {character.Type?.Chunk?.GetType().Name.Replace("questCharacter", "").Replace("_ConditionType", "").Replace("_CondtionType", "")} condition"
        };
    }

    private static string FormatDistanceCondition(questDistanceCondition distance)
    {
        if (distance.Type?.Chunk is questDistanceComparison_ConditionType distComp)
        {
            var comparison = MapComparisonOperator((object)distComp.ComparisonType);
            var distanceValue = distComp.DistanceDefinition2?.Chunk?.DistanceValue;

            // Try to extract both endpoints from DistanceDefinition1 (entityRef and nodeRef2)
            string endpointA = "-";
            string endpointB = "-";

            var objectDistance = distComp.DistanceDefinition1?.Chunk;
            if (objectDistance != null)
            {
                if (objectDistance.EntityRef?.Chunk != null)
                {
                    endpointA = FormatUniversalRef(objectDistance.EntityRef.Chunk);
                }

                // NodeRef2 is a gameEntityReference
                var nodeRefText = ParseGameEntityReference(objectDistance.NodeRef2);
                if (!string.IsNullOrEmpty(nodeRefText) && nodeRefText != "-")
                {
                    endpointB = nodeRefText;
                }
            }

            if (endpointA != "-" && endpointB != "-")
            {
                return $"Distance {endpointA} and {endpointB} {comparison} {distanceValue}m";
            }
            if (endpointA != "-")
            {
                return $"Distance from {endpointA} {comparison} {distanceValue}m";
            }
            if (endpointB != "-")
            {
                return $"Distance to {endpointB} {comparison} {distanceValue}m";
            }

            return $"Distance {comparison} {distanceValue}m";
        }
        return "Distance condition";
    }

    private static string FormatLogicalCondition(questLogicalCondition logical)
    {
        if (logical.Conditions?.Count > 0)
        {
            var operation = logical.Operation.ToString().ToUpper();
            var conditionDescriptions = logical.Conditions
                .Where(c => c?.Chunk != null)
                .Select(c => FormatConditionSemantically(c.Chunk!))
                .ToList();
            
            if (conditionDescriptions.Count == 1)
                return conditionDescriptions[0];
            else if (conditionDescriptions.Count == 2)
                return $"({conditionDescriptions[0]}) {operation} ({conditionDescriptions[1]})";
            else
            {
                // For many conditions, use a more compact format and handle truncation
                var maxDisplayLength = 200; // Reasonable limit for display
                var compactConditions = conditionDescriptions.Select(c => 
                {
                    // Make individual conditions more compact
                    return c.Replace("Player isinside ", "≻")
                           .Replace("Player isoutside ", "≺")
                           .Replace("Player isonenter ", "→")
                           .Replace("Player isonexit ", "←")
                           .Replace(" == ", "=")
                           .Replace(" != ", "≠")
                           .Replace(" > ", ">")
                           .Replace(" < ", "<")
                           .Replace(" >= ", "≥")
                           .Replace(" <= ", "≤");
                }).ToList();
                
                var result = $"{operation}({string.Join(", ", compactConditions)})";
                
                // If still too long, show count and first few
                if (result.Length > maxDisplayLength)
                {
                    var firstFew = compactConditions.Take(3).ToList();
                    var remaining = conditionDescriptions.Count - firstFew.Count;
                    result = $"{operation}({string.Join(", ", firstFew)}{(remaining > 0 ? $", +{remaining} more" : "")})";
                }
                
                return result;
            }
        }
        return "Logical condition";
    }

    private static string FormatSceneCondition(questSceneCondition scene)
    {
        if (scene.Type?.Chunk is questSectionNode_ConditionType section)
        {
            var sceneFile = section.SceneFile.DepotPath.GetResolvedText();
            var sectionName = section.SectionName.ToString();
            var condType = section.Type.ToString().ToLower();
            return $"Scene {sceneFile}:{sectionName} {condType}";
        }
        return "Scene condition";
    }

    private static string FormatJournalCondition(questJournalCondition journal)
    {
        if (journal.Type?.Chunk is questJournalEntryState_ConditionType entryState)
        {
            var state = entryState.State.ToString();
            var inverted = entryState.Inverted ? "not " : "";
            
            // Get the journal path details
            var path = entryState.Path?.Chunk;
            if (path != null)
            {
                // Format className by removing gameJournal prefix and common suffixes
                var className = path.ClassName.ToString()?
                    .Replace("gameJournal", "")
                    .Replace("Entry", "");
                
                var realPath = path.RealPath.ToString();
                
                return $"{className} ({realPath}) {inverted}{state}";
            }
            else
            {
                return $"Journal entry {inverted}{state}";
            }
        }
        else if (journal.Type?.Chunk is questJournalEntryVisited_ConditionType visited)
        {
            var path = visited.Path?.Chunk;
            var flag = visited.Visited ? "visited" : "not visited";
            if (path != null)
            {
                var className = path.ClassName.ToString()?
                    .Replace("gameJournal", "")
                    .Replace("Entry", "");
                var realPath = path.RealPath.ToString();
                return $"{className} ({realPath}) {flag}";
            }
            return $"Journal entry {flag}";
        }
        else if (journal.Type?.Chunk is questJournalEntry_ConditionType entry)
        {
            var path = entry.Path?.Chunk;
            var state = entry.State.ToString();
            if (path != null)
            {
                var className = path.ClassName.ToString()?
                    .Replace("gameJournal", "")
                    .Replace("Entry", "");
                var realPath = path.RealPath.ToString();
                return $"{className} ({realPath}) is {state}";
            }
            return $"Journal entry is {state}";
        }
        else if (journal.Type?.Chunk is questMappinState_ConditionType mappin)
        {
            var path = mappin.MappinPath?.Chunk;
            var state = mappin.Active ? "active" : "inactive";
            if (path != null)
            {
                var className = path.ClassName.ToString()?
                    .Replace("gameJournal", "")
                    .Replace("Entry", "");
                var realPath = path.RealPath.ToString();
                return $"{className} ({realPath}) is {state}";
            }
            return $"Mappin is {state}";
        }
        return "Journal condition";
    }

    private static string ParseGameEntityReference(gameEntityReference? entRef)
    {
        if (entRef == null) return "-";

        string str = "-";

        // Priority 1: DynamicEntityUniqueName (if not None/empty)
        if (!string.IsNullOrEmpty(entRef.DynamicEntityUniqueName) && entRef.DynamicEntityUniqueName != "None")
        {
            str = entRef.DynamicEntityUniqueName!;
        }
        // Priority 2: Reference (if not 0)
        else if (entRef.Reference != 0)
        {
            str = entRef.Reference.GetResolvedText()!;
        }

        // Add Names array as additional context (like community names)
        if (entRef.Names.Count > 0)
        {
            var names = string.Join(", ", entRef.Names);
            if (str != "-")
            {
                str += $" ({names})";
            }
            else
            {
                str = names; // If no reference/dynamic name, use names as primary
            }
        }

        return str;
    }

    private static string FormatUniversalRef(questUniversalRef? universalRef)
    {
        if (universalRef == null)
        {
            return "-";
        }

        // Prefer explicit player flags
        if (universalRef.RefLocalPlayer || universalRef.MainPlayerObject)
        {
            return "Player";
        }

        // Fallback to the embedded entity reference
        return ParseGameEntityReference(universalRef.EntityReference);
    }

    private static string MapComparisonOperator(object? comparison)
    {
        var name = comparison?.ToString() ?? string.Empty;
        return name switch
        {
            "Equal" => "==",
            "NotEqual" => "!=",
            "Greater" => ">",
            "GreaterOrEqual" or "GreaterEqual" => ">=",
            "Less" => "<",
            "LessOrEqual" or "LessEqual" => "<=",
            _ => name
        };
    }

    private static string GetDetailedConditionTypeName(questIBaseCondition condition)
    {
        return condition switch
        {
            questCharacterCondition character => GetCharacterConditionSubTypeName(character),
            questObjectCondition obj => GetObjectConditionSubTypeName(obj),
            questFactsDBCondition facts => GetFactsConditionSubTypeName(facts),
            questTimeCondition time => GetTimeConditionSubTypeName(time),
            questSystemCondition system => GetSystemConditionSubTypeName(system),
            questVehicleCondition vehicle => GetVehicleConditionSubTypeName(vehicle),
            questUICondition ui => GetUIConditionSubTypeName(ui),
            questStatsCondition stats => GetStatsConditionSubTypeName(stats),
            questSpawnerCondition spawner => GetSpawnerConditionSubTypeName(spawner),
            questSensesCondition senses => GetSensesConditionSubTypeName(senses),
            questPaymentCondition payment => GetPaymentConditionSubTypeName(payment),
            questEntityCondition entity => GetEntityConditionSubTypeName(entity),
            questContentCondition content => GetContentConditionSubTypeName(content),
            questDistanceCondition distance => GetDistanceConditionSubTypeName(distance),
            questSceneCondition scene => GetSceneConditionSubTypeName(scene),
            questJournalCondition journal => GetJournalConditionSubTypeName(journal),
            _ => condition.GetType().Name.Replace("quest", "").Replace("Condition", "")
        };
    }

    private static string GetCharacterConditionSubTypeName(questCharacterCondition character)
    {
        if (character.Type?.Chunk == null) return "Character";
        
        var subtype = character.Type.Chunk.GetType().Name
            .Replace("questCharacter", "")
            .Replace("_ConditionType", "")
            .Replace("_CondtionType", ""); // Handle the typo in some class names
        
        return $"Character ({subtype})";
    }

    private static string GetObjectConditionSubTypeName(questObjectCondition obj)
    {
        if (obj.Type?.Chunk == null) return "Object";
        
        var subtype = obj.Type.Chunk.GetType().Name
            .Replace("quest", "")
            .Replace("_ConditionType", "");
        
        return $"Object ({subtype})";
    }

    private static string GetFactsConditionSubTypeName(questFactsDBCondition facts)
    {
        if (facts.Type?.Chunk == null) return "Facts";
        
        var subtype = facts.Type.Chunk.GetType().Name
            .Replace("questVar", "")
            .Replace("_ConditionType", "");
        
        return $"Facts ({subtype})";
    }

    private static string GetTimeConditionSubTypeName(questTimeCondition time)
    {
        if (time.Type?.Chunk == null) return "Time";
        
        var subtype = time.Type.Chunk.GetType().Name
            .Replace("quest", "")
            .Replace("_ConditionType", "");
        
        return $"Time ({subtype})";
    }

    private static string GetSystemConditionSubTypeName(questSystemCondition system)
    {
        if (system.Type?.Chunk == null) return "System";
        
        var subtype = system.Type.Chunk.GetType().Name
            .Replace("quest", "")
            .Replace("_ConditionType", "");
        
        return $"System ({subtype})";
    }

    private static string GetVehicleConditionSubTypeName(questVehicleCondition vehicle)
    {
        if (vehicle.Type?.Chunk == null) return "Vehicle";
        
        var subtype = vehicle.Type.Chunk.GetType().Name
            .Replace("questVehicle", "")
            .Replace("_ConditionType", "");
        
        return $"Vehicle ({subtype})";
    }

    private static string GetUIConditionSubTypeName(questUICondition ui)
    {
        if (ui.Type?.Chunk == null) return "UI";
        
        var subtype = ui.Type.Chunk.GetType().Name
            .Replace("questUI", "")
            .Replace("_ConditionType", "");
        
        return $"UI ({subtype})";
    }

    private static string GetStatsConditionSubTypeName(questStatsCondition stats)
    {
        if (stats.Type?.Chunk == null) return "Stats";
        
        var subtype = stats.Type.Chunk.GetType().Name
            .Replace("quest", "")
            .Replace("_ConditionType", "");
        
        return $"Stats ({subtype})";
    }

    private static string GetSpawnerConditionSubTypeName(questSpawnerCondition spawner)
    {
        if (spawner.Type?.Chunk == null) return "Spawner";
        
        var subtype = spawner.Type.Chunk.GetType().Name
            .Replace("questSpawner", "")
            .Replace("_ConditionType", "");
        
        return $"Spawner ({subtype})";
    }

    private static string GetSensesConditionSubTypeName(questSensesCondition senses)
    {
        if (senses.Type?.Chunk == null) return "Senses";
        
        var subtype = senses.Type.Chunk.GetType().Name
            .Replace("quest", "")
            .Replace("_ConditionType", "");
        
        return $"Senses ({subtype})";
    }

    private static string GetPaymentConditionSubTypeName(questPaymentCondition payment)
    {
        if (payment.Type?.Chunk == null) return "Payment";
        
        var subtype = payment.Type.Chunk.GetType().Name
            .Replace("questPayment", "")
            .Replace("_ConditionType", "");
        
        return $"Payment ({subtype})";
    }

    private static string GetEntityConditionSubTypeName(questEntityCondition entity)
    {
        if (entity.Type?.Chunk == null) return "Entity";
        
        var subtype = entity.Type.Chunk.GetType().Name
            .Replace("questEntity", "")
            .Replace("_ConditionType", "");
        
        return $"Entity ({subtype})";
    }

    private static string GetContentConditionSubTypeName(questContentCondition content)
    {
        if (content.Type?.Chunk == null) return "Content";
        
        var subtype = content.Type.Chunk.GetType().Name
            .Replace("questContent", "")
            .Replace("_ConditionType", "");
        
        return $"Content ({subtype})";
    }

    private static string GetDistanceConditionSubTypeName(questDistanceCondition distance)
    {
        if (distance.Type?.Chunk == null) return "Distance";
        
        var subtype = distance.Type.Chunk.GetType().Name
            .Replace("questDistance", "")
            .Replace("_ConditionType", "");
        
        return $"Distance ({subtype})";
    }

    private static string GetSceneConditionSubTypeName(questSceneCondition scene)
    {
        if (scene.Type?.Chunk == null) return "Scene";
        
        var subtype = scene.Type.Chunk.GetType().Name
            .Replace("quest", "")
            .Replace("_ConditionType", "");
        
        return $"Scene ({subtype})";
    }

    private static string GetJournalConditionSubTypeName(questJournalCondition journal)
    {
        if (journal.Type?.Chunk == null) return "Journal";
        
        var subtype = journal.Type.Chunk.GetType().Name
            .Replace("questJournal", "")
            .Replace("_ConditionType", "");
        
        return $"Journal ({subtype})";
    }

    private static string FormatMountCondition(questCharacterMount_ConditionType mount)
    {
        // Determine the subject (who is mounting)
        string subject;
        if (mount.ChildIsPlayer)
        {
            subject = "Player";
        }
        else
        {
            var childRefText = ParseGameEntityReference(mount.ChildRef);
            subject = childRefText != "-" ? childRefText : "Unknown";
        }

        // Determine the target (what is being mounted)
        string target = "";
        var parentRefText = ParseGameEntityReference(mount.ParentRef);
        if (parentRefText != "-")
        {
            target = $" {parentRefText}";
        }

        var conditionText = mount.Condition.ToString();
        return $"{subject} {conditionText}{target}";
    }

    private static string FormatCharacterStateCondition(questCharacterState_ConditionType state)
    {
        return state.SubType?.Chunk switch
        {
            questCharacterState_PlayerSubType playerState => FormatPlayerState(playerState),
            questCharacterState_PuppetSubType puppetState => FormatPuppetState(puppetState),
            _ => "Character state condition"
        };
    }

    private static string FormatCharacterSpawnedCondition(questCharacterSpawned_ConditionType spawned)
    {
        var target = ParseGameEntityReference(spawned.ObjectRef);
        var countText = spawned.ComparisonParams?.Chunk?.Count;
        var opEnum = spawned.ComparisonParams?.Chunk?.ComparisonType;
        var op = MapComparisonOperator((object?)opEnum);
        return $"{target} spawned count {op} {countText}";
    }

    private static string FormatPlayerState(questCharacterState_PlayerSubType playerState)
    {
        var states = new List<string>();

        // Only include non-default/non-Any states
        if (playerState.LocomotionState != gamePSMLocomotionStates.Any)
        {
            states.Add($"locomotionState {playerState.LocomotionState}");
        }
        if (playerState.UpperBodyState != gamePSMUpperBodyStates.Any)
        {
            states.Add($"upperBodyState {playerState.UpperBodyState}");
        }
        if (playerState.WeaponState != gamePSMRangedWeaponStates.Any)
        {
            states.Add($"weaponState {playerState.WeaponState}");
        }
        if (playerState.VehicleState != gamePSMVehicle.Any)
        {
            states.Add($"vehicleState {playerState.VehicleState}");
        }
        if (playerState.TimeDilationState != gamePSMTimeDilation.Any)
        {
            states.Add($"timeDilationState {playerState.TimeDilationState}");
        }
        if (playerState.TakedownState != gamePSMTakedown.Any)
        {
            states.Add($"takedownState {playerState.TakedownState}");
        }

        if (states.Count == 0)
        {
            return "Player state condition";
        }
        else if (states.Count == 1)
        {
            return $"Player {states[0]}";
        }
        else
        {
            return $"Player {string.Join(" AND ", states)}";
        }
    }

    private static string FormatPuppetState(questCharacterState_PuppetSubType puppetState)
    {
        var target = ParseGameEntityReference(puppetState.PuppetRef);
        var states = new List<string>();

        // Only include non-default states
        if (puppetState.UpperBodyState != 1)
        {
            states.Add($"upperbody {puppetState.UpperBodyState}");
        }
        if (puppetState.HighLevelState != 1)
        {
            states.Add($"highlevel {puppetState.HighLevelState}");
        }
        if (puppetState.StanceState != 0)
        {
            states.Add($"stance {puppetState.StanceState}");
        }

        if (states.Count == 0)
        {
            return $"{target} state condition";
        }
        else if (states.Count == 1)
        {
            return $"{target} {states[0]}";
        }
        else
        {
            return $"{target} {string.Join(" AND ", states)}";
        }
    }

    private static string FormatCharacterKilledCondition(questCharacterKilled_ConditionType killed)
    {
        var target = ParseGameEntityReference(killed.ObjectRef);
        var flags = new List<string>();
        if (killed.Killed) flags.Add("killed");
        if (killed.Unconscious) flags.Add("unconscious");
        if (killed.Defeated) flags.Add("defeated");

        string suffix = flags.Count > 0 ? $" ({string.Join(", ", flags)})" : string.Empty;

        if (killed.ComparisonParams?.Chunk != null)
        {
            var op = MapComparisonOperator((object)killed.ComparisonParams.Chunk.ComparisonType);
            var count = killed.ComparisonParams.Chunk.Count;
            var scope = killed.ComparisonParams.Chunk.EntireCommunity ? "in community" : "";
            return $"{target} killed count {op} {count} {scope}".Trim();
        }

        return $"{target}{suffix}";
    }

    private static string FormatCharacterWorkspotCondition(questCharacterWorkspot_ConditionType workspot)
    {
        var subject = workspot.IsPlayer ? "Player" : ParseGameEntityReference(workspot.PuppetRef);
        var spotRef = workspot.SpotRef.GetResolvedText();
        
        if (!string.IsNullOrEmpty(workspot.AnimationName) && workspot.AnimationName != "None")
        {
            var waitText = workspot.WaitForAnimEnd ? " (wait for end)" : "";
            return $"{subject} at {spotRef} with animation: {workspot.AnimationName}{waitText}";
        }
        
        return $"{subject} at {spotRef}";
    }

    private static string FormatCharacterAimCondition(questCharacterAim_ConditionType aim)
    {
        var subject = aim.IsPlayer ? "Player" : "Character";
        var target = ParseGameEntityReference(aim.TargetRef);
        var aimType = aim.PreciseAiming ? "precisely aiming at" : "aiming at";
        
        return $"{subject} {aimType} {target}";
    }

    private static string FormatCharacterAppearanceCondition(questCharacterAppearancePrefetched_ConditionType appearance)
    {
        var subject = appearance.IsPlayer ? "Player" : ParseGameEntityReference(appearance.PuppetRef);
        
        if (!string.IsNullOrEmpty(appearance.AppearanceName) && appearance.AppearanceName != "None")
        {
            return $"{subject} appearance {appearance.AppearanceName} prefetched";
        }
        
        return $"{subject} appearance prefetched";
    }

    private static string FormatCharacterAttackCondition(questCharacterAttack_ConditionType attack)
    {
        var attacker = ParseGameEntityReference(attack.AttackerRef);
        var target = attack.IsTargetPlayer ? "Player" : ParseGameEntityReference(attack.TargetRef);
        
        return $"{attacker} attacks {target}";
    }

    private static string FormatCharacterCallReinforcementsCondition(questCharacterCallReinforcements_ConditionType reinforcements)
    {
        var puppet = ParseGameEntityReference(reinforcements.PuppetRef);
        return $"{puppet} calls reinforcements";
    }

    private static string FormatCharacterControlledObjectHitCondition(questCharacterControlledObjectHit_ConditionType controlledHit)
    {
        var attacker = ParseGameEntityReference(controlledHit.AttackerRef);
        var target = controlledHit.IsTargetPlayer ? "Player" : ParseGameEntityReference(controlledHit.TargetRef);
        
        var hitDetails = new List<string>();
        
        // Add hit types if specified
        if (controlledHit.IncludeHitTypes?.Count > 0)
        {
            hitDetails.Add($"types: {string.Join(", ", controlledHit.IncludeHitTypes.Select(t => t.ToString()))}");
        }
        if (controlledHit.ExcludeHitTypes?.Count > 0)
        {
            hitDetails.Add($"exclude types: {string.Join(", ", controlledHit.ExcludeHitTypes.Select(t => t.ToString()))}");
        }
        
        // Add hit shapes if specified
        if (controlledHit.IncludeHitShapes?.Count > 0)
        {
            hitDetails.Add($"shapes: {string.Join(", ", controlledHit.IncludeHitShapes)}");
        }
        if (controlledHit.ExcludeHitShapes?.Count > 0)
        {
            hitDetails.Add($"exclude shapes: {string.Join(", ", controlledHit.ExcludeHitShapes)}");
        }
        
        var detailsText = hitDetails.Count > 0 ? $" ({string.Join(", ", hitDetails)})" : "";
        return $"{attacker} hits controlled object of {target}{detailsText}";
    }

    private static string FormatCharacterCoverCondition(questCharacterCover_ConditionType cover)
    {
        var puppet = ParseGameEntityReference(cover.PuppetRef);
        var coverRef = cover.CoverRef.GetResolvedText();
        
        if (!string.IsNullOrEmpty(coverRef) && coverRef != "-")
        {
            return $"{puppet} using cover {coverRef}";
        }
        
        return $"{puppet} using cover";
    }

    private static string FormatCharacterCyberdeckProgramCondition(questCharacterCyberdeckProgram_ConditionType cyberdeck)
    {
        var programID = cyberdeck.CyberdeckProgramID.GetResolvedText();
        
        if (!string.IsNullOrEmpty(programID))
        {
            return $"Cyberdeck program {programID} active";
        }
        
        return "Cyberdeck program active";
    }

    private static string FormatCharacterEquippedItemCondition(questCharacterEquippedItem_ConditionType equippedItem)
    {
        var subject = equippedItem.IsPlayer ? "Player" : ParseGameEntityReference(equippedItem.PuppetRef);
        var hasText = equippedItem.Inverted ? "does not have" : "has";
        
        // Determine what item to check for
        var itemDescription = "";
        
        if (!string.IsNullOrEmpty(equippedItem.ItemID.GetResolvedText()))
        {
            itemDescription = equippedItem.ItemID.GetResolvedText();
        }
        else if (!string.IsNullOrEmpty(equippedItem.ItemTag) && equippedItem.ItemTag != "None")
        {
            itemDescription = $"tag:{equippedItem.ItemTag}";
        }
        else
        {
            itemDescription = "item";
        }
        
        var exclusions = new List<string>();
        if (equippedItem.ExcludedTweakDBIDs?.Count > 0)
        {
            exclusions.Add($"exclude IDs: {string.Join(", ", equippedItem.ExcludedTweakDBIDs.Select(id => id.GetResolvedText()))}");
        }
        if (equippedItem.ExcludedTags?.Count > 0)
        {
            exclusions.Add($"exclude tags: {string.Join(", ", equippedItem.ExcludedTags)}");
        }
        
        var exclusionText = exclusions.Count > 0 ? $" ({string.Join(", ", exclusions)})" : "";
        return $"{subject} {hasText} equipped {itemDescription}{exclusionText}";
    }

    private static string FormatCharacterEquippedWeaponCondition(questCharacterEquippedWeapon_ConditionType equippedWeapon)
    {
        var hasText = equippedWeapon.Inverted ? "does not have" : "has";
        
        if (equippedWeapon.AnyWeaponEquipped)
        {
            return $"Player {hasText} any weapon equipped";
        }
        
        var weaponDescription = "";
        
        if (!string.IsNullOrEmpty(equippedWeapon.WeaponID))
        {
            weaponDescription = equippedWeapon.WeaponID;
        }
        else if (!string.IsNullOrEmpty(equippedWeapon.WeaponTag) && equippedWeapon.WeaponTag != "None")
        {
            weaponDescription = $"tag:{equippedWeapon.WeaponTag}";
        }
        else
        {
            weaponDescription = "weapon";
        }
        
        return $"Player {hasText} {weaponDescription} equipped";
    }

    private static string FormatCharacterLifePathCondition(questCharacterLifePath_ConditionType lifePath)
    {
        var lifePathID = lifePath.LifePathID.GetResolvedText();
        
        if (!string.IsNullOrEmpty(lifePathID))
        {
            // Clean up the life path ID for better readability
            var cleanLifePath = lifePathID
                .Replace("LifePaths.", "")
                .Replace("_", " ");
            
            return $"Player life path is {cleanLifePath}";
        }
        
        return "Player life path condition";
    }

    private static string FormatCharacterMountedTogetherCondition(questCharacterMountedTogether_ConditionType mounted)
    {
        var participants = new List<string>();
        if (mounted.Characters != null)
        {
            foreach (var handle in mounted.Characters)
            {
                var info = handle?.Chunk;
                if (info != null)
                {
                    var refText = info.IsPlayer ? "Player" : ParseGameEntityReference(info.Ref);
                    if (!string.IsNullOrEmpty(refText) && refText != "-")
                    {
                        participants.Add(refText);
                    }
                }
            }
        }

        var vehicleType = mounted.VehicleType.ToString();
        var origin = mounted.VehicleOrigin.ToString();
        var who = participants.Count > 0 ? string.Join(", ", participants) : "characters";
        return $"{who} mounted together on {vehicleType} ({origin})";
    }

    private static string FormatCharacterReactionCondition(questCharacterReaction_ConditionType reaction)
    {
        var puppet = ParseGameEntityReference(reaction.PuppetRef);
        if (reaction.IsAnyReaction)
        {
            return $"{puppet} has any reaction";
        }
        var behavior = reaction.ReactionBehaviorID.GetResolvedText();
        var behaviorText = !string.IsNullOrEmpty(behavior) ? behavior : "reaction";
        return $"{puppet} has reaction {behaviorText}";
    }

    private static string FormatCharacterRoleFinishedCondition(questCharacterRoleFinished_ConditionType roleFinished)
    {
        var target = ParseGameEntityReference(roleFinished.ObjectRef);
        return $"{target} role {roleFinished.Role} finished";
    }

    private static string FormatCharacterQuickHackedCondition(questCharacterQuickHacked_ConditionType quickHacked)
    {
        var target = ParseGameEntityReference(quickHacked.ObjectRef);
        return $"{target} {(quickHacked.QuickHacked ? "is" : "is not")} quickhacked";
    }

    private static string FormatCharacterQuickHackUploadBeginCondition(questCharacterQuickHackUploadBegin_ConditionType begin)
    {
        var target = ParseGameEntityReference(begin.ObjectRef);
        return $"QuickHack upload begins on {target}";
    }

    private static string GetJournalPathLabel(CHandle<gameJournalPath>? pathHandle)
    {
        var path = pathHandle?.Chunk;
        if (path == null)
        {
            return string.Empty;
        }

        var realPath = path.RealPath.ToString();
        if (!string.IsNullOrEmpty(realPath))
        {
            return realPath;
        }

        // Fallback to a cleaned class name
        var className = path.ClassName.ToString()?
            .Replace("gameJournal", "")
            .Replace("Entry", "");
        return className ?? string.Empty;
    }

    private static bool IsPlayerJournalPath(CHandle<gameJournalPath>? pathHandle)
    {
        var path = pathHandle?.Chunk;
        if (path == null)
        {
            return false;
        }

        var realPath = path.RealPath.ToString();
        if (string.IsNullOrEmpty(realPath))
        {
            return false;
        }

        var normalized = realPath.Replace('\\', '/').ToLowerInvariant();
        return normalized == "contacts/player" || normalized.EndsWith("/player");
    }

    private static string FormatPhoneCondition(questPhone_ConditionType phone)
    {
        var callerIsPlayer = IsPlayerJournalPath(phone.Caller);
        var addresseeIsPlayer = IsPlayerJournalPath(phone.Addressee);

        var callerLabel = callerIsPlayer ? "Player" : GetJournalPathLabel(phone.Caller);
        var addresseeLabel = addresseeIsPlayer ? "Player" : GetJournalPathLabel(phone.Addressee);

        switch ((questPhoneCallPhase)phone.CallPhase)
        {
            case questPhoneCallPhase.IncomingCall:
                if (!string.IsNullOrEmpty(callerLabel) && !string.IsNullOrEmpty(addresseeLabel))
                {
                    return $"Incoming call from {callerLabel} to {addresseeLabel}";
                }
                if (addresseeIsPlayer)
                {
                    return "Incoming call to Player";
                }
                if (!string.IsNullOrEmpty(callerLabel))
                {
                    return $"Incoming call from {callerLabel}";
                }
                return "Incoming call";

            case questPhoneCallPhase.StartCall:
                if (callerIsPlayer && !string.IsNullOrEmpty(addresseeLabel))
                {
                    return $"Player calls {addresseeLabel}";
                }
                if (addresseeIsPlayer && !string.IsNullOrEmpty(callerLabel))
                {
                    return $"{callerLabel} calls Player";
                }
                if (!string.IsNullOrEmpty(callerLabel) && !string.IsNullOrEmpty(addresseeLabel))
                {
                    return $"{callerLabel} calls {addresseeLabel}";
                }
                if (!string.IsNullOrEmpty(callerLabel))
                {
                    return $"{callerLabel} initiates a call";
                }
                if (!string.IsNullOrEmpty(addresseeLabel))
                {
                    return $"Call to {addresseeLabel} begins";
                }
                return "Call starts";

            case questPhoneCallPhase.EndCall:
                if (callerIsPlayer || addresseeIsPlayer)
                {
                    return "Call with Player ends";
                }
                if (!string.IsNullOrEmpty(callerLabel) && !string.IsNullOrEmpty(addresseeLabel))
                {
                    return $"Call between {callerLabel} and {addresseeLabel} ends";
                }
                return "Call ends";

            default:
                var phaseName = ((questPhoneCallPhase)phone.CallPhase).ToString();
                if (!string.IsNullOrEmpty(callerLabel) && !string.IsNullOrEmpty(addresseeLabel))
                {
                    return $"Phone {phaseName}: {callerLabel} ↔ {addresseeLabel}";
                }
                if (!string.IsNullOrEmpty(callerLabel))
                {
                    return $"Phone {phaseName} by {callerLabel}";
                }
                if (!string.IsNullOrEmpty(addresseeLabel))
                {
                    return $"Phone {phaseName} with {addresseeLabel}";
                }
                return $"Phone {phaseName}";
        }
    }

    private static string FormatSystemCondition(questSystemCondition system)
    {
        return system.Type?.Chunk switch
        {
            questCameraFocus_ConditionType cameraFocus => 
                $"Camera focused on {ParseGameEntityReference(cameraFocus.ObjectRef)} {(cameraFocus.Inverted ? "(inverted)" : "")}",
            
            questPrereq_ConditionType prereq => 
                $"{(prereq.IsObjectPlayer ? "Player" : ParseGameEntityReference(prereq.ObjectRef))} meets prerequisite",
            
            questPhone_ConditionType phone => 
                FormatPhoneCondition(phone),
            
            _ => $"System {system.Type?.Chunk?.GetType().Name.Replace("quest", "").Replace("_ConditionType", "")} condition"
        };
    }

    private static string FormatVehicleCondition(questVehicleCondition vehicle)
    {
        return vehicle.Type?.Chunk switch
        {
            questVehicleSpeed_ConditionType speed => 
                $"Vehicle speed {MapComparisonOperator((object)speed.ComparisonType)} {speed.Speed}",
            
            questVehicleSpawned_ConditionType spawned => 
                $"Vehicle {ParseGameEntityReference(spawned.VehicleRef)} spawned",
            
            questVehicleCollision_ConditionType collision => 
                $"Vehicle collision with {collision.Magnitude} magnitude",
            
            questVehicleDestruction_ConditionType destruction => 
                $"Vehicle destruction {MapComparisonOperator((object)destruction.ComparisonType)} {destruction.Destruction}%",
            
            _ => $"Vehicle {vehicle.Type?.Chunk?.GetType().Name.Replace("questVehicle", "").Replace("_ConditionType", "")} condition"
        };
    }

    private static string FormatUICondition(questUICondition ui)
    {
        return $"UI {ui.Type?.Chunk?.GetType().Name.Replace("questUI", "").Replace("_ConditionType", "")} condition";
    }

    private static string FormatStatsCondition(questStatsCondition stats)
    {
        return stats.Type?.Chunk switch
        {
            questStat_ConditionType stat => 
                $"Stat {stat.StatType} {MapComparisonOperator((object)stat.ComparisonType)} {stat.Value}",
            
            questDifficulty_ConditionType difficulty => 
                $"Difficulty is {difficulty.Difficulty}",
            
            _ => $"Stats {stats.Type?.Chunk?.GetType().Name.Replace("quest", "").Replace("_ConditionType", "")} condition"
        };
    }

    private static string FormatSpawnerCondition(questSpawnerCondition spawner)
    {
        return spawner.Type?.Chunk switch
        {
            questSpawnerReady_ConditionType ready => 
                $"Spawner {ready.SpawnerReference.GetResolvedText()} is ready",
            
            questSpawnerNotReady_ConditionType notReady => 
                $"Spawner {notReady.SpawnerReference.GetResolvedText()} is not ready",
            
            _ => $"Spawner {spawner.Type?.Chunk?.GetType().Name.Replace("questSpawner", "").Replace("_ConditionType", "")} condition"
        };
    }

    private static string FormatSensesCondition(questSensesCondition senses)
    {
        if (senses.Type?.Chunk is questStimuli_ConditionType stimuli)
        {
            return $"Stimuli {stimuli.Type} from {(stimuli.IsPlayerInstigator ? "Player" : ParseGameEntityReference(stimuli.InstigatorRef))} to {ParseGameEntityReference(stimuli.TargetRef)}";
        }
        if (senses.Type?.Chunk is questVision_ConditionType vision)
        {
            return $"Vision: {ParseGameEntityReference(vision.ObserverPuppetRef)} observes {(vision.IsObservedTargetPlayer ? "Player" : ParseGameEntityReference(vision.ObservedTargetRef))}{(vision.Inverted ? " (inverted)" : "")}";
        }
        return $"Senses {senses.Type?.Chunk?.GetType().Name.Replace("quest", "").Replace("_ConditionType", "")} condition";
    }

    private static string FormatPaymentCondition(questPaymentCondition payment)
    {
        return $"Payment {payment.Type?.Chunk?.GetType().Name.Replace("questPayment", "").Replace("_ConditionType", "")} condition";
    }

    private static string FormatEntityCondition(questEntityCondition entity)
    {
        return $"Entity {entity.Type?.Chunk?.GetType().Name.Replace("questEntity", "").Replace("_ConditionType", "")} condition";
    }

    private static string FormatContentCondition(questContentCondition content)
    {
        return content.Type?.Chunk switch
        {
            questContentToken_ConditionType token => 
                $"Content Token Type is {token.Type}",
            
            questContentLock_ConditionType lockCond =>
                lockCond.IsContentBlocked ? "Content is blocked" : "Content is not blocked",
            
            _ => $"Content {content.Type?.Chunk?.GetType().Name.Replace("questContent", "").Replace("_ConditionType", "")} condition"
        };
    }

    private static string FormatTimePeriodCondition(questTimePeriod_ConditionType timePeriod)
    {
        var beginTime = FormatGameTime(timePeriod.Begin);
        var endTime = FormatGameTime(timePeriod.End);
        
        return $"Time between {beginTime} and {endTime}";
    }

    private static string FormatGameTime(GameTime? gameTime)
    {
        if (gameTime == null)
        {
            return "00:00";
        }

        // GameTime is represented in seconds since midnight
        var totalSeconds = gameTime.Seconds;
        var hours = (totalSeconds / 3600) % 24;
        var minutes = (totalSeconds % 3600) / 60;
        
        return $"{hours:D2}:{minutes:D2}";
    }
}

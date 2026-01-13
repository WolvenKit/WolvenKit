using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Timeline;

/// <summary>
/// ViewModel representing a single event on the timeline.
/// Wraps an scnSceneEvent and exposes StartTime/Duration for binding.
/// </summary>
public partial class TimelineEventViewModel : ObservableObject
{
    private readonly scnSceneEvent _event;
    private readonly Action _onChanged;
    private readonly scnSceneResource? _sceneResource;
    
    /// <summary>
    /// Invalid performer ID value used in scene data (0xFFFFFF00)
    /// </summary>
    private const uint InvalidPerformerId = 4294967040;
    
    /// <summary>
    /// 0-based index of this event in the section's event list
    /// </summary>
    public int EventIndex { get; set; }

    public TimelineEventViewModel(scnSceneEvent sceneEvent, Action onChanged, scnSceneResource? sceneResource = null, int eventIndex = 0)
    {
        _event = sceneEvent ?? throw new ArgumentNullException(nameof(sceneEvent));
        _onChanged = onChanged;
        _sceneResource = sceneResource;
        EventIndex = eventIndex;
        
        _startTime = _event.StartTime;
        _duration = _event.Duration;
    }

    /// <summary>
    /// The underlying scene event data
    /// </summary>
    public scnSceneEvent Event => _event;

    /// <summary>
    /// Event type name for display (e.g., "DialogLineEvent")
    /// </summary>
    public string TypeName => _event.GetType().Name.Replace("scn", "").Replace("scnevents", "");

    /// <summary>
    /// Category for track grouping
    /// </summary>
    public string Category => GetCategoryForEventType(_event.GetType());

    /// <summary>
    /// Display color based on specific event type
    /// </summary>
    public Color Color => GetColorForEventType(_event.GetType());

    /// <summary>
    /// Brush for UI binding
    /// </summary>
    public SolidColorBrush ColorBrush => new(Color);

    [ObservableProperty]
    private uint _startTime;

    [ObservableProperty]
    private uint _duration;

    /// <summary>
    /// Row within the track (for handling overlapping events)
    /// </summary>
    public int Row { get; set; }
    
    /// <summary>
    /// User-preferred row (set when manually dragging vertically, -1 = auto-assign)
    /// </summary>
    public int PreferredRow { get; set; } = -1;

    /// <summary>
    /// End time (StartTime + Duration) for convenience
    /// </summary>
    public uint EndTime => StartTime + Duration;

    /// <summary>
    /// Check if this event overlaps with another event
    /// </summary>
    public bool OverlapsWith(TimelineEventViewModel other)
    {
        // Two events overlap if one starts before the other ends
        return StartTime < other.EndTime && other.StartTime < EndTime;
    }

    partial void OnStartTimeChanged(uint value)
    {
        _event.StartTime = value;
        _onChanged?.Invoke();
        OnPropertyChanged(nameof(EndTime));
    }

    partial void OnDurationChanged(uint value)
    {
        _event.Duration = value;
        _onChanged?.Invoke();
        OnPropertyChanged(nameof(EndTime));
    }

    /// <summary>
    /// Get a short display label for the event (legacy single-line)
    /// </summary>
    public string DisplayLabel => $"{TitleLine} {DetailsLine}".Trim();

    /// <summary>
    /// First line: "#1 EventType (Performer)"
    /// </summary>
    public string TitleLine
    {
        get
        {
            var prefix = $"#{EventIndex}";
            
            if (_event is scnDialogLineEvent dialogLine)
            {
                var speaker = GetDialogSpeaker(dialogLine);
                return $"{prefix} Dialog ({speaker})";
            }
            
            if (_event is scnPlaySkAnimEvent skAnim)
            {
                var performer = ResolvePerformerName(skAnim.Performer?.Id ?? uint.MaxValue);
                return $"{prefix} Sk Anim ({performer})";
            }

            if (_event is scnLookAtEvent lookAt)
            {
                return $"{prefix} LookAt";
            }
            
            if (_event is scnLookAtAdvancedEvent lookAtAdv)
            {
                return $"{prefix} LookAt+";
            }

            if (_event is scnAudioEvent audio)
            {
                var performer = ResolvePerformerName(audio.Performer?.Id ?? uint.MaxValue);
                return string.IsNullOrEmpty(performer) ? $"{prefix} Audio" : $"{prefix} Audio ({performer})";
            }
            
            if (_event is scnChangeIdleAnimEvent idleAnim)
            {
                var performer = ResolvePerformerName(idleAnim.Performer?.Id ?? uint.MaxValue);
                return string.IsNullOrEmpty(performer) ? $"{prefix} Idle" : $"{prefix} Idle ({performer})";
            }
            
            if (_event is scneventsVFXEvent vfx)
            {
                var performer = ResolvePerformerName(vfx.PerformerId?.Id ?? uint.MaxValue);
                return string.IsNullOrEmpty(performer) ? $"{prefix} VFX" : $"{prefix} VFX ({performer})";
            }
            
            if (_event is scneventsVFXDurationEvent vfxDur)
            {
                var performer = ResolvePerformerName(vfxDur.PerformerId?.Id ?? uint.MaxValue);
                return string.IsNullOrEmpty(performer) ? $"{prefix} VFX Duration" : $"{prefix} VFX Duration ({performer})";
            }
            
            if (_event is scnIKEvent ik)
            {
                var performer = ResolvePerformerName(ik.IkData?.Basic?.PerformerId?.Id ?? uint.MaxValue);
                return string.IsNullOrEmpty(performer) ? $"{prefix} IK" : $"{prefix} IK ({performer})";
            }
            
            if (_event is scneventsSocket socket)
            {
                return $"{prefix} Socket";
            }

            return $"{prefix} {TypeName}";
        }
    }

    /// <summary>
    /// Second line: event-specific details
    /// </summary>
    public string DetailsLine
    {
        get
        {
            if (_event is scnDialogLineEvent dialogLine)
            {
                return GetDialogText(dialogLine);
            }
            
            if (_event is scnPlaySkAnimEvent skAnim)
            {
                return GetAnimName(skAnim);
            }

            if (_event is scnLookAtEvent lookAt)
            {
                return GetLookAtDetails(lookAt);
            }
            
            if (_event is scnLookAtAdvancedEvent lookAtAdv)
            {
                return GetLookAtAdvancedDetails(lookAtAdv);
            }

            if (_event is scnAudioEvent audio)
            {
                return audio.AudioEventName != CName.Empty ? audio.AudioEventName.GetResolvedText() ?? "" : "";
            }
            
            if (_event is scnChangeIdleAnimEvent idleAnim)
            {
                return GetIdleAnimDetails(idleAnim);
            }
            
            if (_event is scneventsVFXEvent vfx)
            {
                return GetVfxDetails(vfx);
            }
            
            if (_event is scneventsVFXDurationEvent vfxDur)
            {
                return GetVfxDurationDetails(vfxDur);
            }
            
            if (_event is scnIKEvent ik)
            {
                return GetIkDetails(ik);
            }
            
            if (_event is scneventsSocket socket)
            {
                return GetSocketDetails(socket);
            }

            return "";
        }
    }
    
    private string GetDialogLabel(scnDialogLineEvent dialogLine)
    {
        string speakerName = "";
        string dialogueSnippet = "";
        
        if (dialogLine.ScreenplayLineId != null && _sceneResource != null)
        {
            CUInt32 screenplayId = dialogLine.ScreenplayLineId.Id;
            var screenplayLine = _sceneResource.ScreenplayStore?.Lines?.FirstOrDefault(line => line.ItemId?.Id == screenplayId);

            if (screenplayLine != null)
            {
                // Get speaker information
                if (screenplayLine.Speaker != null && screenplayLine.Speaker.Id != uint.MaxValue)
                {
                    speakerName = _sceneResource.ResolveActorName(screenplayLine.Speaker.Id);
                }

                // Get dialogue text if available
                if (screenplayLine.LocstringId != null && 
                    _sceneResource.LocStore?.VdEntries != null &&
                    _sceneResource.LocStore?.VpEntries != null)
                {
                    CRUID locstringRuid = screenplayLine.LocstringId.Ruid;
                    string? dialogueText = null;

                    var preferredLocaleId = WolvenKit.RED4.Types.Enums.scnlocLocaleId.en_us;
                    var vdEntryPreferred = _sceneResource.LocStore.VdEntries.FirstOrDefault(vd => 
                        vd.LocstringId?.Ruid == locstringRuid && vd.LocaleId == preferredLocaleId);

                    if (vdEntryPreferred?.VariantId != null)
                    {
                        CRUID targetVariantRuid = vdEntryPreferred.VariantId.Ruid;
                        var vpEntry = _sceneResource.LocStore.VpEntries.FirstOrDefault(vp => vp.VariantId?.Ruid == targetVariantRuid);
                        dialogueText = vpEntry?.Content;
                    }

                    if (string.IsNullOrEmpty(dialogueText))
                    {
                        var vdEntryFallback = _sceneResource.LocStore.VdEntries.FirstOrDefault(vd => 
                            vd.LocstringId?.Ruid == locstringRuid && vd.LocaleId != preferredLocaleId);
                        if (vdEntryFallback?.VariantId != null)
                        {
                            CRUID fallbackVariantRuid = vdEntryFallback.VariantId.Ruid;
                            var vpEntryFallback = _sceneResource.LocStore.VpEntries.FirstOrDefault(vp => vp.VariantId?.Ruid == fallbackVariantRuid);
                            dialogueText = vpEntryFallback?.Content;
                        }
                    }

                    if (!string.IsNullOrEmpty(dialogueText))
                    {
                        const int maxLen = 25;
                        dialogueSnippet = dialogueText.Length > maxLen 
                            ? dialogueText.Substring(0, maxLen) + "..." 
                            : dialogueText;
                    }
                }
            }
        }
        
        if (!string.IsNullOrEmpty(speakerName) && !string.IsNullOrEmpty(dialogueSnippet))
            return $"{speakerName}: \"{dialogueSnippet}\"";
        if (!string.IsNullOrEmpty(speakerName))
            return $"{speakerName}: [Dialog {dialogLine.ScreenplayLineId?.Id}]";
        if (!string.IsNullOrEmpty(dialogueSnippet))
            return $"Dialog: \"{dialogueSnippet}\"";
        return $"Dialog ({dialogLine.ScreenplayLineId?.Id})";
    }
    
    private string GetAnimLabel(scnPlaySkAnimEvent skAnim)
    {
        string performerName = ResolvePerformerName(skAnim.Performer?.Id ?? uint.MaxValue);
        string animName = "";
        
        if (skAnim.AnimName?.GetValue() is scnAnimName animNameObj 
            && animNameObj.Unk1 != null && animNameObj.Unk1.Count > 0)
        {
            animName = animNameObj.Unk1[0].GetResolvedText() ?? "";
            if (animName.Length > 25)
                animName = animName.Substring(0, 25) + "...";
        }
        
        if (!string.IsNullOrEmpty(performerName) && !string.IsNullOrEmpty(animName))
            return $"{performerName}: {animName}";
        if (!string.IsNullOrEmpty(animName))
            return $"Anim: {animName}";
        return "SkAnim";
    }
    
    private string GetLookAtLabel(scnLookAtEvent lookAt)
    {
        if (lookAt.BasicData?.Basic != null && _sceneResource != null)
        {
            var basicData = lookAt.BasicData.Basic;
            string performerName = ResolvePerformerName(basicData.PerformerId?.Id ?? uint.MaxValue);
            string targetName = ResolveTargetFromAnimData(basicData);
            
            if (basicData.IsStart)
                return $"{performerName} → {targetName}";
            else
                return $"{performerName} stop";
        }
        return "LookAt";
    }
    
    private string GetLookAtAdvancedLabel(scnLookAtAdvancedEvent lookAtAdv)
    {
        if (lookAtAdv.AdvancedData?.Basic != null && _sceneResource != null)
        {
            var basicData = lookAtAdv.AdvancedData.Basic;
            string performerName = ResolvePerformerName(basicData.PerformerId?.Id ?? uint.MaxValue);
            string targetName = ResolveTargetFromAnimData(basicData);
            
            if (basicData.IsStart)
                return $"{performerName} → {targetName}";
            else
                return $"{performerName} stop";
        }
        return "LookAt+";
    }
    
    private string GetAudioLabel(scnAudioEvent audio)
    {
        string performerName = ResolvePerformerName(audio.Performer?.Id ?? uint.MaxValue);
        string audioName = audio.AudioEventName != CName.Empty ? audio.AudioEventName.GetResolvedText() ?? "" : "";
        
        if (audioName.Length > 20)
            audioName = audioName.Substring(0, 20) + "...";
        
        if (!string.IsNullOrEmpty(performerName) && !string.IsNullOrEmpty(audioName))
            return $"{performerName}: {audioName}";
        if (!string.IsNullOrEmpty(audioName))
            return $"Audio: {audioName}";
        return "Audio";
    }
    
    private string GetIdleAnimLabel(scnChangeIdleAnimEvent idleAnim)
    {
        string performerName = ResolvePerformerName(idleAnim.Performer?.Id ?? uint.MaxValue);
        string idleName = idleAnim.IdleAnimName != CName.Empty 
            ? idleAnim.IdleAnimName.GetResolvedText() ?? "" 
            : "";
        
        if (idleName.Length > 20)
            idleName = idleName.Substring(0, 20) + "...";
        
        if (!string.IsNullOrEmpty(performerName) && !string.IsNullOrEmpty(idleName))
            return $"{performerName}: {idleName}";
        if (!string.IsNullOrEmpty(idleName))
            return $"Idle: {idleName}";
        return "IdleAnim";
    }
    
    private string ResolvePerformerName(uint performerId)
    {
        if (_sceneResource == null) return "";
        if (performerId == uint.MaxValue || performerId == InvalidPerformerId) return "";
        
        if (performerId == 0)
        {
            var playerActor = _sceneResource.PlayerActors?.FirstOrDefault(p => p.ActorId?.Id == 0);
            if (playerActor != null)
                return string.IsNullOrEmpty(playerActor.PlayerName) ? "Player" : playerActor.PlayerName;
            return "Player";
        }
        
        if (performerId >= 1 && (performerId % 256 == 1))
        {
            uint actorIndex = (performerId - 1) / 256;
            
            var playerActor = _sceneResource.PlayerActors?.FirstOrDefault(p => p.ActorId?.Id == actorIndex);
            if (playerActor != null)
                return string.IsNullOrEmpty(playerActor.PlayerName) ? "Player" : playerActor.PlayerName;

            if (_sceneResource.Actors != null && actorIndex < _sceneResource.Actors.Count)
            {
                var actorDef = _sceneResource.Actors[(int)actorIndex];
                return actorDef?.ActorName ?? $"Actor{actorIndex}";
            }
        }
        
        return "";
    }
    
    private string ResolveTargetFromAnimData(scnAnimTargetBasicData basicData)
    {
        if (_sceneResource == null) return "Target";
        
        var targetType = (WolvenKit.RED4.Types.Enums.scnLookAtTargetType)basicData.TargetType;
        
        switch (targetType)
        {
            case WolvenKit.RED4.Types.Enums.scnLookAtTargetType.Actor:
                // Use TargetPerformerId when TargetType is Actor
                if (basicData.TargetPerformerId != null && basicData.TargetPerformerId.Id != InvalidPerformerId)
                {
                    return ResolvePerformerName(basicData.TargetPerformerId.Id);
                }
                // If no valid performer, check for static target
                if (basicData.StaticTarget.X != 0 || basicData.StaticTarget.Y != 0 || basicData.StaticTarget.Z != 0)
                {
                    return $"Pos({basicData.StaticTarget.X:F0},{basicData.StaticTarget.Y:F0},{basicData.StaticTarget.Z:F0})";
                }
                return "None";
                
            case WolvenKit.RED4.Types.Enums.scnLookAtTargetType.Prop:
                if (basicData.TargetPropId != null)
                {
                    var propDef = _sceneResource.Props?.FirstOrDefault(p => p.PropId?.Id == basicData.TargetPropId.Id);
                    return propDef?.PropName ?? $"Prop[{basicData.TargetPropId.Id}]";
                }
                return "Prop";
                
            default:
                // Check StaticTarget first
                if (basicData.StaticTarget.X != 0 || basicData.StaticTarget.Y != 0 || basicData.StaticTarget.Z != 0)
                {
                    return $"Pos({basicData.StaticTarget.X:F0},{basicData.StaticTarget.Y:F0},{basicData.StaticTarget.Z:F0})";
                }
                // Then check TargetPerformerId
                if (basicData.TargetPerformerId != null && basicData.TargetPerformerId.Id != InvalidPerformerId)
                {
                    return ResolvePerformerName(basicData.TargetPerformerId.Id);
                }
                // Then check TargetSlot
                if (basicData.TargetSlot != CName.Empty)
                {
                    return $"Slot:{basicData.TargetSlot.GetResolvedText() ?? "?"}";
                }
                return $"Unknown({targetType})";
        }
    }
    
    private string GetDialogSpeaker(scnDialogLineEvent dialogLine)
    {
        if (dialogLine.ScreenplayLineId != null && _sceneResource != null)
        {
            CUInt32 screenplayId = dialogLine.ScreenplayLineId.Id;
            var screenplayLine = _sceneResource.ScreenplayStore?.Lines?.FirstOrDefault(line => line.ItemId?.Id == screenplayId);
            if (screenplayLine?.Speaker != null && screenplayLine.Speaker.Id != uint.MaxValue)
            {
                return _sceneResource.ResolveActorName(screenplayLine.Speaker.Id);
            }
        }
        return "";
    }
    
    private string GetDialogText(scnDialogLineEvent dialogLine)
    {
        if (dialogLine.ScreenplayLineId != null && _sceneResource != null)
        {
            CUInt32 screenplayId = dialogLine.ScreenplayLineId.Id;
            var screenplayLine = _sceneResource.ScreenplayStore?.Lines?.FirstOrDefault(line => line.ItemId?.Id == screenplayId);
            
            if (screenplayLine?.LocstringId != null && 
                _sceneResource.LocStore?.VdEntries != null &&
                _sceneResource.LocStore?.VpEntries != null)
            {
                CRUID locstringRuid = screenplayLine.LocstringId.Ruid;
                var preferredLocaleId = WolvenKit.RED4.Types.Enums.scnlocLocaleId.en_us;
                var vdEntry = _sceneResource.LocStore.VdEntries.FirstOrDefault(vd => 
                    vd.LocstringId?.Ruid == locstringRuid && vd.LocaleId == preferredLocaleId);
                
                if (vdEntry?.VariantId != null)
                {
                    var vpEntry = _sceneResource.LocStore.VpEntries.FirstOrDefault(vp => vp.VariantId?.Ruid == vdEntry.VariantId.Ruid);
                    if (vpEntry?.Content != null)
                    {
                        string text = vpEntry.Content.ToString() ?? "";
                        return text.Length > 40 ? text.Substring(0, 40) + "..." : text;
                    }
                }
            }
        }
        return "";
    }
    
    private string GetAnimName(scnPlaySkAnimEvent skAnim)
    {
        if (skAnim.AnimName?.GetValue() is scnAnimName animNameObj 
            && animNameObj.Unk1 != null && animNameObj.Unk1.Count > 0)
        {
            var animName = animNameObj.Unk1[0].GetResolvedText() ?? "";
            return animName.Length > 35 ? animName.Substring(0, 35) + "..." : animName;
        }
        return "";
    }
    
    private string GetLookAtDetails(scnLookAtEvent lookAt)
    {
        if (lookAt.BasicData?.Basic != null && _sceneResource != null)
        {
            var basicData = lookAt.BasicData.Basic;
            string performerName = ResolvePerformerName(basicData.PerformerId?.Id ?? uint.MaxValue);
            string targetName = ResolveTargetFromAnimData(basicData);
            
            if (basicData.IsStart)
                return $"{performerName} → {targetName}";
            else
                return $"{performerName} stop";
        }
        return "";
    }
    
    private string GetLookAtAdvancedDetails(scnLookAtAdvancedEvent lookAtAdv)
    {
        if (lookAtAdv.AdvancedData?.Basic != null && _sceneResource != null)
        {
            var basicData = lookAtAdv.AdvancedData.Basic;
            string performerName = ResolvePerformerName(basicData.PerformerId?.Id ?? uint.MaxValue);
            string targetName = ResolveTargetFromAnimData(basicData);
            
            if (basicData.IsStart)
                return $"{performerName} → {targetName}";
            else
                return $"{performerName} stop";
        }
        return "";
    }
    
    private string GetIdleAnimDetails(scnChangeIdleAnimEvent idleAnim)
    {
        var parts = new List<string>();
        
        // Try IdleAnimName first
        if (idleAnim.IdleAnimName != CName.Empty)
        {
            var name = idleAnim.IdleAnimName.GetResolvedText() ?? "";
            if (!string.IsNullOrEmpty(name))
                parts.Add(name.Length > 30 ? name.Substring(0, 30) + "..." : name);
        }
        // Then AnimName
        else if (idleAnim.AnimName != CName.Empty)
        {
            var name = idleAnim.AnimName.GetResolvedText() ?? "";
            if (!string.IsNullOrEmpty(name))
                parts.Add(name.Length > 30 ? name.Substring(0, 30) + "..." : name);
        }
        // Then AddIdleAnimName
        else if (idleAnim.AddIdleAnimName != CName.Empty)
        {
            var name = idleAnim.AddIdleAnimName.GetResolvedText() ?? "";
            if (!string.IsNullOrEmpty(name))
                parts.Add(name.Length > 30 ? name.Substring(0, 30) + "..." : name);
        }
        
        // Check for facial animation info
        if (idleAnim.BakedFacialTransition != null)
        {
            CName facialCName = CName.Empty;
            if (idleAnim.BakedFacialTransition.ToIdleFemale != CName.Empty)
                facialCName = idleAnim.BakedFacialTransition.ToIdleFemale;
            else if (idleAnim.BakedFacialTransition.ToIdleMale != CName.Empty)
                facialCName = idleAnim.BakedFacialTransition.ToIdleMale;
                
            if (facialCName != CName.Empty)
            {
                var facialName = facialCName.GetResolvedText() ?? "";
                if (!string.IsNullOrEmpty(facialName))
                    parts.Add($"Face:{facialName}");
            }
        }
        
        return string.Join(", ", parts);
    }
    
    private string GetVfxDetails(scneventsVFXEvent vfx)
    {
        var parts = new List<string>();
        
        // Action type
        parts.Add(vfx.Action.ToString());
        
        // Effect name
        if (vfx.EffectEntry?.EffectName != null && vfx.EffectEntry.EffectName != CName.Empty)
        {
            var effectName = vfx.EffectEntry.EffectName.GetResolvedText() ?? "";
            if (!string.IsNullOrEmpty(effectName))
                parts.Add(effectName.Length > 25 ? effectName.Substring(0, 25) + "..." : effectName);
        }
        
        return string.Join(": ", parts);
    }
    
    private string GetVfxDurationDetails(scneventsVFXDurationEvent vfxDur)
    {
        var parts = new List<string>();
        
        // Start/End actions
        parts.Add($"{vfxDur.StartAction}→{vfxDur.EndAction}");
        
        // Effect name
        if (vfxDur.EffectEntry?.EffectName != null && vfxDur.EffectEntry.EffectName != CName.Empty)
        {
            var effectName = vfxDur.EffectEntry.EffectName.GetResolvedText() ?? "";
            if (!string.IsNullOrEmpty(effectName))
                parts.Add(effectName.Length > 25 ? effectName.Substring(0, 25) + "..." : effectName);
        }
        
        return string.Join(": ", parts);
    }
    
    private string GetIkDetails(scnIKEvent ik)
    {
        if (ik.IkData?.ChainName != null && ik.IkData.ChainName != CName.Empty)
        {
            var chainName = ik.IkData.ChainName.GetResolvedText() ?? "";
            if (!string.IsNullOrEmpty(chainName))
                return $"Chain: {chainName}";
        }
        return "";
    }
    
    private string GetSocketDetails(scneventsSocket socket)
    {
        if (socket.OsockStamp == null)
            return "";
        
        // Name and Ordinal are CUInt16 indexes
        var name = (ushort)socket.OsockStamp.Name;
        var ordinal = (ushort)socket.OsockStamp.Ordinal;
        
        if (name != ushort.MaxValue && ordinal != ushort.MaxValue)
            return $"({name}, {ordinal})";
        return "";
    }

    /// <summary>
    /// Maps event types to categories for track grouping
    /// </summary>
    public static string GetCategoryForEventType(Type eventType)
    {
        var name = eventType.Name;

        // Dialogue
        if (name.Contains("DialogLine"))
            return "Dialogue";

        // Animation
        if (name.Contains("Anim") || name.Contains("Idle"))
            return "Animation";

        // LookAt
        if (name.Contains("LookAt"))
            return "LookAt";

        // Audio
        if (name.Contains("Audio"))
            return "Audio";

        // Camera
        if (name.Contains("Camera"))
            return "Camera";

        // VFX
        if (name.Contains("VFX"))
            return "VFX";

        // Gameplay
        if (name.Contains("Gameplay"))
            return "Gameplay";

        // Placement/Transform
        if (name.Contains("Placement") || name.Contains("Pose") || name.Contains("IK"))
            return "Placement";

        return "Other";
    }

    /// <summary>
    /// Maps categories to colors for visual distinction
    /// </summary>
    public static Color GetColorForCategory(string category)
    {
        return category switch
        {
            "Dialogue" => Color.FromRgb(26, 94, 203),    // Blue
            "Animation" => Color.FromRgb(25, 163, 62),    // Green
            "LookAt" => Color.FromRgb(200, 151, 4),       // Yellow
            "Audio" => Color.FromRgb(182, 36, 22),        // Red
            "Camera" => Color.FromRgb(154, 99, 191),      // Purple
            "VFX" => Color.FromRgb(245, 106, 0),          // Orange
            "Gameplay" => Color.FromRgb(0, 172, 193),     // Cyan
            "Placement" => Color.FromRgb(158, 158, 158),  // Gray
            _ => Color.FromRgb(117, 117, 117)             // Dark Gray
        };
    }
    
    /// <summary>
    /// Maps specific event types to colors for more granular visual distinction
    /// </summary>
    public static Color GetColorForEventType(Type eventType)
    {
        var name = eventType.Name;
        
        // Animation events - different green tints
        if (name == "scnPlaySkAnimEvent")
            return Color.FromRgb(52, 168, 83);        // Standard green
        if (name == "scnChangeIdleAnimEvent")
            return Color.FromRgb(76, 175, 80);        // Lighter green tint
        if (name.Contains("Anim"))
            return Color.FromRgb(67, 160, 71);        // Medium green for other anim events
            
        // LookAt events - different yellow tints
        if (name == "scnLookAtEvent")
            return Color.FromRgb(251, 188, 5);        // Standard yellow
        if (name == "scnLookAtAdvancedEvent")
            return Color.FromRgb(255, 202, 40);       // Lighter yellow tint
        if (name.Contains("LookAt"))
            return Color.FromRgb(253, 195, 20);       // Medium yellow for other lookat events
            
        // Fall back to category color for all other types
        var category = GetCategoryForEventType(eventType);
        return GetColorForCategory(category);
    }
}

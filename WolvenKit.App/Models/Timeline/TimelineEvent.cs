using System;
using System.Collections.Generic;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.App.Helpers;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Models.Timeline;

public partial class TimelineEvent : ObservableObject
{
    private readonly scnSceneEvent _event;
    private readonly Action _onChanged;
    private readonly scnSceneResource? _sceneResource;
    
    private const uint InvalidPerformerId = 4294967040;
    
    public int EventIndex { get; set; }

    public TimelineEvent(scnSceneEvent sceneEvent, Action onChanged, scnSceneResource? sceneResource = null, int eventIndex = 0)
    {
        _event = sceneEvent ?? throw new ArgumentNullException(nameof(sceneEvent));
        _onChanged = onChanged;
        _sceneResource = sceneResource;
        EventIndex = eventIndex;
        
        _startTime = _event.StartTime;
        _duration = _event.Duration;
    }

    public scnSceneEvent Event => _event;
    public string TypeName => _event.GetType().Name.Replace("scn", "").Replace("scnevents", "");
    public string Category => TimelineColorHelper.GetCategoryForEventType(_event.GetType());
    public Type EventType => _event.GetType();

    [ObservableProperty]
    private uint _startTime;

    [ObservableProperty]
    private uint _duration;

    public int Row { get; set; }
    public int PreferredRow { get; set; } = -1;
    public uint EndTime => StartTime + Duration;

    public bool OverlapsWith(TimelineEvent other)
    {
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

    public string DisplayLabel => $"{TitleLine} {DetailsLine}".Trim();

    public string TitleLine
    {
        get
        {
            var prefix = $"#{EventIndex}";
            
            switch (_event)
            {
                case scnDialogLineEvent dialogLine:
                    var speaker = GetDialogSpeaker(dialogLine);
                    return $"{prefix} Dialog ({speaker})";
                
                case scnPlaySkAnimEvent skAnim:
                    var skAnimPerformer = ResolvePerformerName(skAnim.Performer?.Id ?? uint.MaxValue);
                    return $"{prefix} Sk Anim ({skAnimPerformer})";
                
                case scnLookAtEvent:
                    return $"{prefix} LookAt";
                
                case scnLookAtAdvancedEvent:
                    return $"{prefix} LookAt+";
                
                case scnAudioEvent audio:
                    var audioPerformer = ResolvePerformerName(audio.Performer?.Id ?? uint.MaxValue);
                    return string.IsNullOrEmpty(audioPerformer) ? $"{prefix} Audio" : $"{prefix} Audio ({audioPerformer})";
                
                case scnChangeIdleAnimEvent idleAnim:
                    var idlePerformer = ResolvePerformerName(idleAnim.Performer?.Id ?? uint.MaxValue);
                    return string.IsNullOrEmpty(idlePerformer) ? $"{prefix} Idle" : $"{prefix} Idle ({idlePerformer})";
                
                case scneventsVFXEvent vfx:
                    var vfxPerformer = ResolvePerformerName(vfx.PerformerId?.Id ?? uint.MaxValue);
                    return string.IsNullOrEmpty(vfxPerformer) ? $"{prefix} VFX" : $"{prefix} VFX ({vfxPerformer})";
                
                case scneventsVFXDurationEvent vfxDur:
                    var vfxDurPerformer = ResolvePerformerName(vfxDur.PerformerId?.Id ?? uint.MaxValue);
                    return string.IsNullOrEmpty(vfxDurPerformer) ? $"{prefix} VFX Duration" : $"{prefix} VFX Duration ({vfxDurPerformer})";
                
                case scnIKEvent ik:
                    var ikPerformer = ResolvePerformerName(ik.IkData?.Basic?.PerformerId?.Id ?? uint.MaxValue);
                    return string.IsNullOrEmpty(ikPerformer) ? $"{prefix} IK" : $"{prefix} IK ({ikPerformer})";
                
                case scneventsSocket:
                    return $"{prefix} Socket";
                
                default:
                    return $"{prefix} {TypeName}";
            }
        }
    }

    public string DetailsLine
    {
        get
        {
            switch (_event)
            {
                case scnDialogLineEvent dialogLine:
                    return GetDialogText(dialogLine);
                
                case scnPlaySkAnimEvent skAnim:
                    return GetAnimName(skAnim);
                
                case scnLookAtEvent lookAt:
                    return GetLookAtDetails(lookAt);
                
                case scnLookAtAdvancedEvent lookAtAdv:
                    return GetLookAtAdvancedDetails(lookAtAdv);
                
                case scnAudioEvent audio:
                    return audio.AudioEventName != CName.Empty ? audio.AudioEventName.GetResolvedText() ?? "" : "";
                
                case scnChangeIdleAnimEvent idleAnim:
                    return GetIdleAnimDetails(idleAnim);
                
                case scneventsVFXEvent vfx:
                    return GetVfxDetails(vfx);
                
                case scneventsVFXDurationEvent vfxDur:
                    return GetVfxDurationDetails(vfxDur);
                
                case scnIKEvent ik:
                    return GetIkDetails(ik);
                
                case scneventsSocket socket:
                    return GetSocketDetails(socket);
                
                default:
                    return "";
            }
        }
    }
    
    private string ResolvePerformerName(uint performerId)
    {
        if (_sceneResource == null)
        {
            return "";
        }
        if (performerId == uint.MaxValue || performerId == InvalidPerformerId)
        {
            return "";
        }
        
        if (performerId == 0)
        {
            var playerActor = _sceneResource.PlayerActors?.FirstOrDefault(p => p.ActorId?.Id == 0);
            if (playerActor != null)
            {
                return string.IsNullOrEmpty(playerActor.PlayerName) ? "Player" : playerActor.PlayerName;
            }
            return "Player";
        }
        
        if (performerId >= 1 && (performerId % 256 == 1))
        {
            uint actorIndex = (performerId - 1) / 256;
            
            var playerActor = _sceneResource.PlayerActors?.FirstOrDefault(p => p.ActorId?.Id == actorIndex);
            if (playerActor != null)
            {
                return string.IsNullOrEmpty(playerActor.PlayerName) ? "Player" : playerActor.PlayerName;
            }

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
        if (_sceneResource == null) 
        {
            return "Target";
        }
        
        var targetType = (WolvenKit.RED4.Types.Enums.scnLookAtTargetType)basicData.TargetType;
        
        switch (targetType)
        {
            case WolvenKit.RED4.Types.Enums.scnLookAtTargetType.Actor:
                if (basicData.TargetPerformerId != null && basicData.TargetPerformerId.Id != InvalidPerformerId)
                {
                    return ResolvePerformerName(basicData.TargetPerformerId.Id);
                }
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
                if (basicData.StaticTarget.X != 0 || basicData.StaticTarget.Y != 0 || basicData.StaticTarget.Z != 0)
                {
                    return $"Pos({basicData.StaticTarget.X:F0},{basicData.StaticTarget.Y:F0},{basicData.StaticTarget.Z:F0})";
                }
                if (basicData.TargetPerformerId != null && basicData.TargetPerformerId.Id != InvalidPerformerId)
                {
                    return ResolvePerformerName(basicData.TargetPerformerId.Id);
                }
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
                        return StringHelper.Truncate(vpEntry.Content.ToString() ?? "", 40);
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
            return StringHelper.Truncate(animNameObj.Unk1[0].GetResolvedText() ?? "", 35);
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
            
            return basicData.IsStart ? $"{performerName} → {targetName}" : $"{performerName} stop";
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
            
            return basicData.IsStart ? $"{performerName} → {targetName}" : $"{performerName} stop";
        }
        return "";
    }
    
    private string GetIdleAnimDetails(scnChangeIdleAnimEvent idleAnim)
    {
        var parts = new List<string>();
        
        if (idleAnim.IdleAnimName != CName.Empty)
        {
            var name = idleAnim.IdleAnimName.GetResolvedText() ?? "";
            if (!string.IsNullOrEmpty(name))
            {
                parts.Add(StringHelper.Truncate(name, 30));
            }
        }
        else if (idleAnim.AnimName != CName.Empty)
        {
            var name = idleAnim.AnimName.GetResolvedText() ?? "";
            if (!string.IsNullOrEmpty(name))
            {
                parts.Add(StringHelper.Truncate(name, 30));
            }
        }
        else if (idleAnim.AddIdleAnimName != CName.Empty)
        {
            var name = idleAnim.AddIdleAnimName.GetResolvedText() ?? "";
            if (!string.IsNullOrEmpty(name))
            {
                parts.Add(StringHelper.Truncate(name, 30));
            }
        }
        
        if (idleAnim.BakedFacialTransition != null)
        {
            CName facialCName = CName.Empty;
            if (idleAnim.BakedFacialTransition.ToIdleFemale != CName.Empty)
            {
                facialCName = idleAnim.BakedFacialTransition.ToIdleFemale;
            }
            else if (idleAnim.BakedFacialTransition.ToIdleMale != CName.Empty)
            {
                facialCName = idleAnim.BakedFacialTransition.ToIdleMale;
            }
                
            if (facialCName != CName.Empty)
            {
                var facialName = facialCName.GetResolvedText() ?? "";
                if (!string.IsNullOrEmpty(facialName))
                {
                    parts.Add($"Facial: {StringHelper.Truncate(facialName, 20)}");
                }
            }
        }
        
        return string.Join(", ", parts);
    }
    
    private string GetVfxDetails(scneventsVFXEvent vfx)
    {
        var parts = new List<string>();
        parts.Add(vfx.Action.ToString());
        
        if (vfx.EffectEntry?.EffectName != null && vfx.EffectEntry.EffectName != CName.Empty)
        {
            var effectName = vfx.EffectEntry.EffectName.GetResolvedText() ?? "";
            if (!string.IsNullOrEmpty(effectName))
            {
                parts.Add(StringHelper.Truncate(effectName, 25));
            }
        }
        
        return string.Join(": ", parts);
    }
    
    private string GetVfxDurationDetails(scneventsVFXDurationEvent vfxDur)
    {
        var parts = new List<string>();
        parts.Add($"{vfxDur.StartAction}→{vfxDur.EndAction}");
        
        if (vfxDur.EffectEntry?.EffectName != null && vfxDur.EffectEntry.EffectName != CName.Empty)
        {
            var effectName = vfxDur.EffectEntry.EffectName.GetResolvedText() ?? "";
            if (!string.IsNullOrEmpty(effectName))
            {
                parts.Add(StringHelper.Truncate(effectName, 20));
            }
        }
        
        return string.Join(": ", parts);
    }
    
    private string GetIkDetails(scnIKEvent ik)
    {
        if (ik.IkData?.ChainName != null && ik.IkData.ChainName != CName.Empty)
        {
            var chainName = ik.IkData.ChainName.GetResolvedText() ?? "";
            if (!string.IsNullOrEmpty(chainName))
            {
                return StringHelper.Truncate(chainName, 30);
            }
        }
        return "";
    }
    
    private string GetSocketDetails(scneventsSocket socket)
    {
        if (socket.OsockStamp == null)
        {
            return "";
        }
        
        var name = (ushort)socket.OsockStamp.Name;
        var ordinal = (ushort)socket.OsockStamp.Ordinal;
        
        if (name != ushort.MaxValue && ordinal != ushort.MaxValue)
        {
            return $"({name}, {ordinal})";
        }
        return "";
    }
}

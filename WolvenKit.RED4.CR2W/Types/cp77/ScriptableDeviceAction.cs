using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScriptableDeviceAction : BaseScriptableAction
	{
		private CHandle<gamedeviceActionProperty> _prop;
		private SActionWidgetPackage _actionWidgetPackage;
		private NodeRef _spiderbotActionLocationOverride;
		private CFloat _duration;
		private CBool _canTriggerStim;
		private CBool _wasPerformedOnOwner;
		private CBool _shouldActivateDevice;
		private CBool _isQuickHack;
		private CBool _isSpiderbotAction;
		private TweakDBID _attachedProgram;
		private TweakDBID _activeStatusEffect;
		private TweakDBID _interactionIconType;
		private CBool _hasInteraction;
		private CString _inactiveReason;

		[Ordinal(11)] 
		[RED("prop")] 
		public CHandle<gamedeviceActionProperty> Prop
		{
			get => GetProperty(ref _prop);
			set => SetProperty(ref _prop, value);
		}

		[Ordinal(12)] 
		[RED("actionWidgetPackage")] 
		public SActionWidgetPackage ActionWidgetPackage
		{
			get => GetProperty(ref _actionWidgetPackage);
			set => SetProperty(ref _actionWidgetPackage, value);
		}

		[Ordinal(13)] 
		[RED("spiderbotActionLocationOverride")] 
		public NodeRef SpiderbotActionLocationOverride
		{
			get => GetProperty(ref _spiderbotActionLocationOverride);
			set => SetProperty(ref _spiderbotActionLocationOverride, value);
		}

		[Ordinal(14)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(15)] 
		[RED("canTriggerStim")] 
		public CBool CanTriggerStim
		{
			get => GetProperty(ref _canTriggerStim);
			set => SetProperty(ref _canTriggerStim, value);
		}

		[Ordinal(16)] 
		[RED("wasPerformedOnOwner")] 
		public CBool WasPerformedOnOwner
		{
			get => GetProperty(ref _wasPerformedOnOwner);
			set => SetProperty(ref _wasPerformedOnOwner, value);
		}

		[Ordinal(17)] 
		[RED("shouldActivateDevice")] 
		public CBool ShouldActivateDevice
		{
			get => GetProperty(ref _shouldActivateDevice);
			set => SetProperty(ref _shouldActivateDevice, value);
		}

		[Ordinal(18)] 
		[RED("isQuickHack")] 
		public CBool IsQuickHack
		{
			get => GetProperty(ref _isQuickHack);
			set => SetProperty(ref _isQuickHack, value);
		}

		[Ordinal(19)] 
		[RED("isSpiderbotAction")] 
		public CBool IsSpiderbotAction
		{
			get => GetProperty(ref _isSpiderbotAction);
			set => SetProperty(ref _isSpiderbotAction, value);
		}

		[Ordinal(20)] 
		[RED("attachedProgram")] 
		public TweakDBID AttachedProgram
		{
			get => GetProperty(ref _attachedProgram);
			set => SetProperty(ref _attachedProgram, value);
		}

		[Ordinal(21)] 
		[RED("activeStatusEffect")] 
		public TweakDBID ActiveStatusEffect
		{
			get => GetProperty(ref _activeStatusEffect);
			set => SetProperty(ref _activeStatusEffect, value);
		}

		[Ordinal(22)] 
		[RED("interactionIconType")] 
		public TweakDBID InteractionIconType
		{
			get => GetProperty(ref _interactionIconType);
			set => SetProperty(ref _interactionIconType, value);
		}

		[Ordinal(23)] 
		[RED("hasInteraction")] 
		public CBool HasInteraction
		{
			get => GetProperty(ref _hasInteraction);
			set => SetProperty(ref _hasInteraction, value);
		}

		[Ordinal(24)] 
		[RED("inactiveReason")] 
		public CString InactiveReason
		{
			get => GetProperty(ref _inactiveReason);
			set => SetProperty(ref _inactiveReason, value);
		}

		public ScriptableDeviceAction(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

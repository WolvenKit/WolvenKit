using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceSetup : CVariable
	{
		private CName _actionName;
		private CBool _disableOnActivation;
		private CBool _glitchOnActivation;
		private gameFxResource _vfxResource;
		private CName _activationVFXname;
		private CBool _hasSimpleInteraction;
		private CBool _hasSpiderbotInteraction;
		private CBool _hasQuickHack;
		private CBool _hasQuickHackDistraction;
		private TweakDBID _alternativeInteractionName;
		private TweakDBID _alternativeSpiderbotInteractionName;
		private TweakDBID _alternativeQuickHackName;
		private CHandle<EngDemoContainer> _activatedDeviceSkillChecks;
		private TweakDBID _attackType;
		private CBool _shouldActivateTrapOnAreaEnter;
		private TweakDBID _deviceWidgetRecord;
		private TweakDBID _thumbnailIconRecord;
		private TweakDBID _actionWidgetRecord;

		[Ordinal(0)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get => GetProperty(ref _actionName);
			set => SetProperty(ref _actionName, value);
		}

		[Ordinal(1)] 
		[RED("disableOnActivation")] 
		public CBool DisableOnActivation
		{
			get => GetProperty(ref _disableOnActivation);
			set => SetProperty(ref _disableOnActivation, value);
		}

		[Ordinal(2)] 
		[RED("glitchOnActivation")] 
		public CBool GlitchOnActivation
		{
			get => GetProperty(ref _glitchOnActivation);
			set => SetProperty(ref _glitchOnActivation, value);
		}

		[Ordinal(3)] 
		[RED("vfxResource")] 
		public gameFxResource VfxResource
		{
			get => GetProperty(ref _vfxResource);
			set => SetProperty(ref _vfxResource, value);
		}

		[Ordinal(4)] 
		[RED("activationVFXname")] 
		public CName ActivationVFXname
		{
			get => GetProperty(ref _activationVFXname);
			set => SetProperty(ref _activationVFXname, value);
		}

		[Ordinal(5)] 
		[RED("hasSimpleInteraction")] 
		public CBool HasSimpleInteraction
		{
			get => GetProperty(ref _hasSimpleInteraction);
			set => SetProperty(ref _hasSimpleInteraction, value);
		}

		[Ordinal(6)] 
		[RED("hasSpiderbotInteraction")] 
		public CBool HasSpiderbotInteraction
		{
			get => GetProperty(ref _hasSpiderbotInteraction);
			set => SetProperty(ref _hasSpiderbotInteraction, value);
		}

		[Ordinal(7)] 
		[RED("hasQuickHack")] 
		public CBool HasQuickHack
		{
			get => GetProperty(ref _hasQuickHack);
			set => SetProperty(ref _hasQuickHack, value);
		}

		[Ordinal(8)] 
		[RED("hasQuickHackDistraction")] 
		public CBool HasQuickHackDistraction
		{
			get => GetProperty(ref _hasQuickHackDistraction);
			set => SetProperty(ref _hasQuickHackDistraction, value);
		}

		[Ordinal(9)] 
		[RED("alternativeInteractionName")] 
		public TweakDBID AlternativeInteractionName
		{
			get => GetProperty(ref _alternativeInteractionName);
			set => SetProperty(ref _alternativeInteractionName, value);
		}

		[Ordinal(10)] 
		[RED("alternativeSpiderbotInteractionName")] 
		public TweakDBID AlternativeSpiderbotInteractionName
		{
			get => GetProperty(ref _alternativeSpiderbotInteractionName);
			set => SetProperty(ref _alternativeSpiderbotInteractionName, value);
		}

		[Ordinal(11)] 
		[RED("alternativeQuickHackName")] 
		public TweakDBID AlternativeQuickHackName
		{
			get => GetProperty(ref _alternativeQuickHackName);
			set => SetProperty(ref _alternativeQuickHackName, value);
		}

		[Ordinal(12)] 
		[RED("activatedDeviceSkillChecks")] 
		public CHandle<EngDemoContainer> ActivatedDeviceSkillChecks
		{
			get => GetProperty(ref _activatedDeviceSkillChecks);
			set => SetProperty(ref _activatedDeviceSkillChecks, value);
		}

		[Ordinal(13)] 
		[RED("attackType")] 
		public TweakDBID AttackType
		{
			get => GetProperty(ref _attackType);
			set => SetProperty(ref _attackType, value);
		}

		[Ordinal(14)] 
		[RED("shouldActivateTrapOnAreaEnter")] 
		public CBool ShouldActivateTrapOnAreaEnter
		{
			get => GetProperty(ref _shouldActivateTrapOnAreaEnter);
			set => SetProperty(ref _shouldActivateTrapOnAreaEnter, value);
		}

		[Ordinal(15)] 
		[RED("deviceWidgetRecord")] 
		public TweakDBID DeviceWidgetRecord
		{
			get => GetProperty(ref _deviceWidgetRecord);
			set => SetProperty(ref _deviceWidgetRecord, value);
		}

		[Ordinal(16)] 
		[RED("thumbnailIconRecord")] 
		public TweakDBID ThumbnailIconRecord
		{
			get => GetProperty(ref _thumbnailIconRecord);
			set => SetProperty(ref _thumbnailIconRecord, value);
		}

		[Ordinal(17)] 
		[RED("actionWidgetRecord")] 
		public TweakDBID ActionWidgetRecord
		{
			get => GetProperty(ref _actionWidgetRecord);
			set => SetProperty(ref _actionWidgetRecord, value);
		}

		public ActivatedDeviceSetup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

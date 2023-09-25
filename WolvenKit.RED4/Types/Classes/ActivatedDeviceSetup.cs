using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActivatedDeviceSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("disableOnActivation")] 
		public CBool DisableOnActivation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("glitchOnActivation")] 
		public CBool GlitchOnActivation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("vfxResource")] 
		public gameFxResource VfxResource
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		[Ordinal(4)] 
		[RED("activationVFXname")] 
		public CName ActivationVFXname
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("hasSimpleInteraction")] 
		public CBool HasSimpleInteraction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("hasSpiderbotInteraction")] 
		public CBool HasSpiderbotInteraction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("hasQuickHack")] 
		public CBool HasQuickHack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("hasQuickHackDistraction")] 
		public CBool HasQuickHackDistraction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("alternativeInteractionName")] 
		public TweakDBID AlternativeInteractionName
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(10)] 
		[RED("alternativeSpiderbotInteractionName")] 
		public TweakDBID AlternativeSpiderbotInteractionName
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(11)] 
		[RED("alternativeQuickHackName")] 
		public TweakDBID AlternativeQuickHackName
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(12)] 
		[RED("activatedDeviceSkillChecks")] 
		public CHandle<EngDemoContainer> ActivatedDeviceSkillChecks
		{
			get => GetPropertyValue<CHandle<EngDemoContainer>>();
			set => SetPropertyValue<CHandle<EngDemoContainer>>(value);
		}

		[Ordinal(13)] 
		[RED("attackType")] 
		public TweakDBID AttackType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(14)] 
		[RED("shouldActivateTrapOnAreaEnter")] 
		public CBool ShouldActivateTrapOnAreaEnter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("shouldRagdollOnAttack")] 
		public CBool ShouldRagdollOnAttack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("deviceWidgetRecord")] 
		public TweakDBID DeviceWidgetRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(17)] 
		[RED("thumbnailIconRecord")] 
		public TweakDBID ThumbnailIconRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(18)] 
		[RED("actionWidgetRecord")] 
		public TweakDBID ActionWidgetRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public ActivatedDeviceSetup()
		{
			ActionName = "LocKey#233";
			VfxResource = new gameFxResource();
			ShouldRagdollOnAttack = true;
			ThumbnailIconRecord = "DeviceIcons.GenenericDeviceIcon";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

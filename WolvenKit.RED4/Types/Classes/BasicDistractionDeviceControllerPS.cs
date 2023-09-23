using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BasicDistractionDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("distractorType")] 
		public CEnum<EPlaystyleType> DistractorType
		{
			get => GetPropertyValue<CEnum<EPlaystyleType>>();
			set => SetPropertyValue<CEnum<EPlaystyleType>>(value);
		}

		[Ordinal(108)] 
		[RED("basicDistractionDeviceSkillChecks")] 
		public CHandle<EngDemoContainer> BasicDistractionDeviceSkillChecks
		{
			get => GetPropertyValue<CHandle<EngDemoContainer>>();
			set => SetPropertyValue<CHandle<EngDemoContainer>>(value);
		}

		[Ordinal(109)] 
		[RED("effectOnStartNames")] 
		public CArray<CName> EffectOnStartNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(110)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get => GetPropertyValue<CEnum<EAnimationType>>();
			set => SetPropertyValue<CEnum<EAnimationType>>(value);
		}

		[Ordinal(111)] 
		[RED("forceAnimationSystem")] 
		public CBool ForceAnimationSystem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(112)] 
		[RED("overrideDistractionActionId")] 
		public TweakDBID OverrideDistractionActionId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public BasicDistractionDeviceControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

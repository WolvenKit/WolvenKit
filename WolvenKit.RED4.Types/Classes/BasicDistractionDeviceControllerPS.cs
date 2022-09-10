using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BasicDistractionDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("distractorType")] 
		public CEnum<EPlaystyleType> DistractorType
		{
			get => GetPropertyValue<CEnum<EPlaystyleType>>();
			set => SetPropertyValue<CEnum<EPlaystyleType>>(value);
		}

		[Ordinal(105)] 
		[RED("basicDistractionDeviceSkillChecks")] 
		public CHandle<EngDemoContainer> BasicDistractionDeviceSkillChecks
		{
			get => GetPropertyValue<CHandle<EngDemoContainer>>();
			set => SetPropertyValue<CHandle<EngDemoContainer>>(value);
		}

		[Ordinal(106)] 
		[RED("effectOnStartNames")] 
		public CArray<CName> EffectOnStartNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(107)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get => GetPropertyValue<CEnum<EAnimationType>>();
			set => SetPropertyValue<CEnum<EAnimationType>>(value);
		}

		[Ordinal(108)] 
		[RED("forceAnimationSystem")] 
		public CBool ForceAnimationSystem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public BasicDistractionDeviceControllerPS()
		{
			DeviceName = "LocKey#42164";
			TweakDBRecord = 97438729774;
			TweakDBDescriptionRecord = 147273950574;
			DistractorType = Enums.EPlaystyleType.NETRUNNER;
			EffectOnStartNames = new();
			AnimationType = Enums.EAnimationType.TRANSFORM;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

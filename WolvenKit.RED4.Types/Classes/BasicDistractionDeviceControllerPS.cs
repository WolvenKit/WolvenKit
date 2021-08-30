using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BasicDistractionDeviceControllerPS : ScriptableDeviceComponentPS
	{
		private CEnum<EPlaystyleType> _distractorType;
		private CHandle<EngDemoContainer> _basicDistractionDeviceSkillChecks;
		private CArray<CName> _effectOnSartNames;
		private CEnum<EAnimationType> _animationType;
		private CBool _forceAnimationSystem;

		[Ordinal(104)] 
		[RED("distractorType")] 
		public CEnum<EPlaystyleType> DistractorType
		{
			get => GetProperty(ref _distractorType);
			set => SetProperty(ref _distractorType, value);
		}

		[Ordinal(105)] 
		[RED("basicDistractionDeviceSkillChecks")] 
		public CHandle<EngDemoContainer> BasicDistractionDeviceSkillChecks
		{
			get => GetProperty(ref _basicDistractionDeviceSkillChecks);
			set => SetProperty(ref _basicDistractionDeviceSkillChecks, value);
		}

		[Ordinal(106)] 
		[RED("effectOnSartNames")] 
		public CArray<CName> EffectOnSartNames
		{
			get => GetProperty(ref _effectOnSartNames);
			set => SetProperty(ref _effectOnSartNames, value);
		}

		[Ordinal(107)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get => GetProperty(ref _animationType);
			set => SetProperty(ref _animationType, value);
		}

		[Ordinal(108)] 
		[RED("forceAnimationSystem")] 
		public CBool ForceAnimationSystem
		{
			get => GetProperty(ref _forceAnimationSystem);
			set => SetProperty(ref _forceAnimationSystem, value);
		}

		public BasicDistractionDeviceControllerPS()
		{
			_distractorType = new() { Value = Enums.EPlaystyleType.NETRUNNER };
			_animationType = new() { Value = Enums.EAnimationType.TRANSFORM };
		}
	}
}

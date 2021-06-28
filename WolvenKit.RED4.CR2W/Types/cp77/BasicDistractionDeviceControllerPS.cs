using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BasicDistractionDeviceControllerPS : ScriptableDeviceComponentPS
	{
		private CEnum<EPlaystyleType> _distractorType;
		private CHandle<EngDemoContainer> _basicDistractionDeviceSkillChecks;
		private CArray<CName> _effectOnSartNames;
		private CEnum<EAnimationType> _animationType;
		private CBool _forceAnimationSystem;

		[Ordinal(103)] 
		[RED("distractorType")] 
		public CEnum<EPlaystyleType> DistractorType
		{
			get => GetProperty(ref _distractorType);
			set => SetProperty(ref _distractorType, value);
		}

		[Ordinal(104)] 
		[RED("basicDistractionDeviceSkillChecks")] 
		public CHandle<EngDemoContainer> BasicDistractionDeviceSkillChecks
		{
			get => GetProperty(ref _basicDistractionDeviceSkillChecks);
			set => SetProperty(ref _basicDistractionDeviceSkillChecks, value);
		}

		[Ordinal(105)] 
		[RED("effectOnSartNames")] 
		public CArray<CName> EffectOnSartNames
		{
			get => GetProperty(ref _effectOnSartNames);
			set => SetProperty(ref _effectOnSartNames, value);
		}

		[Ordinal(106)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get => GetProperty(ref _animationType);
			set => SetProperty(ref _animationType, value);
		}

		[Ordinal(107)] 
		[RED("forceAnimationSystem")] 
		public CBool ForceAnimationSystem
		{
			get => GetProperty(ref _forceAnimationSystem);
			set => SetProperty(ref _forceAnimationSystem, value);
		}

		public BasicDistractionDeviceControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

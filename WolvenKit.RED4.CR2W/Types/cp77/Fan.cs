using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Fan : BasicDistractionDevice
	{
		private CEnum<EAnimationType> _animationType;
		private CBool _rotateClockwise;
		private CBool _randomizeBladesSpeed;
		private CFloat _maxRotationSpeed;
		private CFloat _timeToMaxRotation;
		private CHandle<AnimFeature_RotatingObject> _animFeature;
		private CHandle<UpdateComponent> _updateComp;

		[Ordinal(102)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get => GetProperty(ref _animationType);
			set => SetProperty(ref _animationType, value);
		}

		[Ordinal(103)] 
		[RED("rotateClockwise")] 
		public CBool RotateClockwise
		{
			get => GetProperty(ref _rotateClockwise);
			set => SetProperty(ref _rotateClockwise, value);
		}

		[Ordinal(104)] 
		[RED("randomizeBladesSpeed")] 
		public CBool RandomizeBladesSpeed
		{
			get => GetProperty(ref _randomizeBladesSpeed);
			set => SetProperty(ref _randomizeBladesSpeed, value);
		}

		[Ordinal(105)] 
		[RED("maxRotationSpeed")] 
		public CFloat MaxRotationSpeed
		{
			get => GetProperty(ref _maxRotationSpeed);
			set => SetProperty(ref _maxRotationSpeed, value);
		}

		[Ordinal(106)] 
		[RED("timeToMaxRotation")] 
		public CFloat TimeToMaxRotation
		{
			get => GetProperty(ref _timeToMaxRotation);
			set => SetProperty(ref _timeToMaxRotation, value);
		}

		[Ordinal(107)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_RotatingObject> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		[Ordinal(108)] 
		[RED("updateComp")] 
		public CHandle<UpdateComponent> UpdateComp
		{
			get => GetProperty(ref _updateComp);
			set => SetProperty(ref _updateComp, value);
		}

		public Fan(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

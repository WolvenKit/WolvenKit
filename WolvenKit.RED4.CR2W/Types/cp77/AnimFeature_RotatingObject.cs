using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_RotatingObject : animAnimFeature
	{
		private CBool _rotateClockwise;
		private CBool _randomizeBladesRotation;
		private CFloat _maxRotationSpeed;
		private CFloat _timeToMaxRotation;

		[Ordinal(0)] 
		[RED("rotateClockwise")] 
		public CBool RotateClockwise
		{
			get => GetProperty(ref _rotateClockwise);
			set => SetProperty(ref _rotateClockwise, value);
		}

		[Ordinal(1)] 
		[RED("randomizeBladesRotation")] 
		public CBool RandomizeBladesRotation
		{
			get => GetProperty(ref _randomizeBladesRotation);
			set => SetProperty(ref _randomizeBladesRotation, value);
		}

		[Ordinal(2)] 
		[RED("maxRotationSpeed")] 
		public CFloat MaxRotationSpeed
		{
			get => GetProperty(ref _maxRotationSpeed);
			set => SetProperty(ref _maxRotationSpeed, value);
		}

		[Ordinal(3)] 
		[RED("timeToMaxRotation")] 
		public CFloat TimeToMaxRotation
		{
			get => GetProperty(ref _timeToMaxRotation);
			set => SetProperty(ref _timeToMaxRotation, value);
		}

		public AnimFeature_RotatingObject(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

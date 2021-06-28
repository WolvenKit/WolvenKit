using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_CrowdLocomotion : animAnimFeature
	{
		private CFloat _speed;
		private CFloat _slopeAngle;
		private CBool _isCrowd;

		[Ordinal(0)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		[Ordinal(1)] 
		[RED("slopeAngle")] 
		public CFloat SlopeAngle
		{
			get => GetProperty(ref _slopeAngle);
			set => SetProperty(ref _slopeAngle, value);
		}

		[Ordinal(2)] 
		[RED("isCrowd")] 
		public CBool IsCrowd
		{
			get => GetProperty(ref _isCrowd);
			set => SetProperty(ref _isCrowd, value);
		}

		public animAnimFeature_CrowdLocomotion(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

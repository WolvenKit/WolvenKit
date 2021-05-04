using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileSlideTrajectoryParams : gameprojectileTrajectoryParams
	{
		private CFloat _stickiness;
		private Vector4 _constAccel;

		[Ordinal(0)] 
		[RED("stickiness")] 
		public CFloat Stickiness
		{
			get => GetProperty(ref _stickiness);
			set => SetProperty(ref _stickiness, value);
		}

		[Ordinal(1)] 
		[RED("constAccel")] 
		public Vector4 ConstAccel
		{
			get => GetProperty(ref _constAccel);
			set => SetProperty(ref _constAccel, value);
		}

		public gameprojectileSlideTrajectoryParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_Pose360 : animAnimNode_Base
	{
		private animFloatLink _angle;
		private CName _animation;

		[Ordinal(11)] 
		[RED("angle")] 
		public animFloatLink Angle
		{
			get => GetProperty(ref _angle);
			set => SetProperty(ref _angle, value);
		}

		[Ordinal(12)] 
		[RED("animation")] 
		public CName Animation
		{
			get => GetProperty(ref _animation);
			set => SetProperty(ref _animation, value);
		}
	}
}

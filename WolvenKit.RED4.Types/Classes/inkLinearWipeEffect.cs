using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkLinearWipeEffect : inkIEffect
	{
		private CFloat _angle;
		private CFloat _transition;

		[Ordinal(2)] 
		[RED("angle")] 
		public CFloat Angle
		{
			get => GetProperty(ref _angle);
			set => SetProperty(ref _angle, value);
		}

		[Ordinal(3)] 
		[RED("transition")] 
		public CFloat Transition
		{
			get => GetProperty(ref _transition);
			set => SetProperty(ref _transition, value);
		}
	}
}

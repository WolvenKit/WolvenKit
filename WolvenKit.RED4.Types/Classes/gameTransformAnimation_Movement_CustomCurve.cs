using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTransformAnimation_Movement_CustomCurve : gameTransformAnimation_Movement
	{
		private CLegacySingleChannelCurve<CFloat> _curve;

		[Ordinal(0)] 
		[RED("curve")] 
		public CLegacySingleChannelCurve<CFloat> Curve
		{
			get => GetProperty(ref _curve);
			set => SetProperty(ref _curve, value);
		}
	}
}

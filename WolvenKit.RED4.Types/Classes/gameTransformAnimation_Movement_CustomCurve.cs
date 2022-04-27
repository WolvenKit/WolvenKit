using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTransformAnimation_Movement_CustomCurve : gameTransformAnimation_Movement
	{
		[Ordinal(0)] 
		[RED("curve")] 
		public CLegacySingleChannelCurve<CFloat> Curve
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		public gameTransformAnimation_Movement_CustomCurve()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

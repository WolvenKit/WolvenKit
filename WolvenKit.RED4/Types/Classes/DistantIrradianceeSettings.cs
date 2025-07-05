using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DistantIrradianceeSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("distantRange")] 
		public CLegacySingleChannelCurve<Vector2> DistantRange
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<Vector2>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<Vector2>>(value);
		}

		[Ordinal(3)] 
		[RED("distantHeightRange")] 
		public CLegacySingleChannelCurve<Vector3> DistantHeightRange
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<Vector3>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<Vector3>>(value);
		}

		[Ordinal(4)] 
		[RED("distantLights")] 
		public CLegacySingleChannelCurve<CFloat> DistantLights
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(5)] 
		[RED("distantLightsRange")] 
		public CLegacySingleChannelCurve<Vector2> DistantLightsRange
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<Vector2>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<Vector2>>(value);
		}

		[Ordinal(6)] 
		[RED("blendDistance")] 
		public CLegacySingleChannelCurve<CFloat> BlendDistance
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		public DistantIrradianceeSettings()
		{
			Enable = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DistantIrradianceeSettings : IAreaSettings
	{
		private CLegacySingleChannelCurve<Vector2> _distantRange;
		private CLegacySingleChannelCurve<Vector3> _distantHeightRange;
		private CLegacySingleChannelCurve<CFloat> _distantLights;
		private CLegacySingleChannelCurve<Vector2> _distantLightsRange;
		private CLegacySingleChannelCurve<CFloat> _blendDistance;

		[Ordinal(2)] 
		[RED("distantRange")] 
		public CLegacySingleChannelCurve<Vector2> DistantRange
		{
			get => GetProperty(ref _distantRange);
			set => SetProperty(ref _distantRange, value);
		}

		[Ordinal(3)] 
		[RED("distantHeightRange")] 
		public CLegacySingleChannelCurve<Vector3> DistantHeightRange
		{
			get => GetProperty(ref _distantHeightRange);
			set => SetProperty(ref _distantHeightRange, value);
		}

		[Ordinal(4)] 
		[RED("distantLights")] 
		public CLegacySingleChannelCurve<CFloat> DistantLights
		{
			get => GetProperty(ref _distantLights);
			set => SetProperty(ref _distantLights, value);
		}

		[Ordinal(5)] 
		[RED("distantLightsRange")] 
		public CLegacySingleChannelCurve<Vector2> DistantLightsRange
		{
			get => GetProperty(ref _distantLightsRange);
			set => SetProperty(ref _distantLightsRange, value);
		}

		[Ordinal(6)] 
		[RED("blendDistance")] 
		public CLegacySingleChannelCurve<CFloat> BlendDistance
		{
			get => GetProperty(ref _blendDistance);
			set => SetProperty(ref _blendDistance, value);
		}
	}
}

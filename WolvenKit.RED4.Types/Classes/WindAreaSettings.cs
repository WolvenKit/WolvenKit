using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WindAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("strength")] 
		public CLegacySingleChannelCurve<CFloat> Strength
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(3)] 
		[RED("direction")] 
		public CLegacySingleChannelCurve<Vector4> Direction
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<Vector4>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<Vector4>>(value);
		}

		public WindAreaSettings()
		{
			Enable = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

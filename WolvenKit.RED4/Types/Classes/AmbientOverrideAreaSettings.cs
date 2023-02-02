using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AmbientOverrideAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("color", 6)] 
		public CArrayFixedSize<CLegacySingleChannelCurve<HDRColor>> Color
		{
			get => GetPropertyValue<CArrayFixedSize<CLegacySingleChannelCurve<HDRColor>>>();
			set => SetPropertyValue<CArrayFixedSize<CLegacySingleChannelCurve<HDRColor>>>(value);
		}

		public AmbientOverrideAreaSettings()
		{
			Color = new(6);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

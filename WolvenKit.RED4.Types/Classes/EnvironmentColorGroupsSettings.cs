using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EnvironmentColorGroupsSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("skyTint")] 
		public CLegacySingleChannelCurve<HDRColor> SkyTint
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<HDRColor>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<HDRColor>>(value);
		}

		[Ordinal(3)] 
		[RED("colorGroup", 16)] 
		public CArrayFixedSize<CLegacySingleChannelCurve<HDRColor>> ColorGroup
		{
			get => GetPropertyValue<CArrayFixedSize<CLegacySingleChannelCurve<HDRColor>>>();
			set => SetPropertyValue<CArrayFixedSize<CLegacySingleChannelCurve<HDRColor>>>(value);
		}

		public EnvironmentColorGroupsSettings()
		{
			Enable = true;
			ColorGroup = new(16);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

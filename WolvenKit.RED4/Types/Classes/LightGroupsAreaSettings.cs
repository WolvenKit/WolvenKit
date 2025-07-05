using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LightGroupsAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("groupFade", 8)] 
		public CArrayFixedSize<CLegacySingleChannelCurve<CFloat>> GroupFade
		{
			get => GetPropertyValue<CArrayFixedSize<CLegacySingleChannelCurve<CFloat>>>();
			set => SetPropertyValue<CArrayFixedSize<CLegacySingleChannelCurve<CFloat>>>(value);
		}

		public LightGroupsAreaSettings()
		{
			Enable = true;
			GroupFade = new(8);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

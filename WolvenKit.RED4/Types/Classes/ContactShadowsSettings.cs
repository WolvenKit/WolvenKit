using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ContactShadowsSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("contactShadows")] 
		public ContactShadowsConfig ContactShadows
		{
			get => GetPropertyValue<ContactShadowsConfig>();
			set => SetPropertyValue<ContactShadowsConfig>(value);
		}

		public ContactShadowsSettings()
		{
			Enable = true;
			ContactShadows = new ContactShadowsConfig { Range = 0.050000F, RangeLimit = 0.075000F, ScreenEdgeFadeRange = 0.150000F, DistanceFadeLimit = 3.000000F, DistanceFadeRange = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

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
			ContactShadows = new ContactShadowsConfig();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

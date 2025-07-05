using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questHUDEntryVisibilityData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("hudEntryName")] 
		public CName HudEntryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("visibility")] 
		public CEnum<worlduiEntryVisibility> Visibility
		{
			get => GetPropertyValue<CEnum<worlduiEntryVisibility>>();
			set => SetPropertyValue<CEnum<worlduiEntryVisibility>>(value);
		}

		public questHUDEntryVisibilityData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

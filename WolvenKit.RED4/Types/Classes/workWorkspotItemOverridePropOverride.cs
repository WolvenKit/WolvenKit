using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workWorkspotItemOverridePropOverride : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("prevItemId")] 
		public CName PrevItemId
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("newItemId")] 
		public CName NewItemId
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public workWorkspotItemOverridePropOverride()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

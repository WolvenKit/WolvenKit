using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workWorkspotItemOverride : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("propOverrides")] 
		public CArray<workWorkspotItemOverridePropOverride> PropOverrides
		{
			get => GetPropertyValue<CArray<workWorkspotItemOverridePropOverride>>();
			set => SetPropertyValue<CArray<workWorkspotItemOverridePropOverride>>(value);
		}

		[Ordinal(1)] 
		[RED("itemOverrides")] 
		public CArray<workWorkspotItemOverrideItemOverride> ItemOverrides
		{
			get => GetPropertyValue<CArray<workWorkspotItemOverrideItemOverride>>();
			set => SetPropertyValue<CArray<workWorkspotItemOverrideItemOverride>>(value);
		}

		public workWorkspotItemOverride()
		{
			PropOverrides = new();
			ItemOverrides = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

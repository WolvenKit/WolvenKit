using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workWorkspotItemOverride : RedBaseClass
	{
		private CArray<workWorkspotItemOverridePropOverride> _propOverrides;
		private CArray<workWorkspotItemOverrideItemOverride> _itemOverrides;

		[Ordinal(0)] 
		[RED("propOverrides")] 
		public CArray<workWorkspotItemOverridePropOverride> PropOverrides
		{
			get => GetProperty(ref _propOverrides);
			set => SetProperty(ref _propOverrides, value);
		}

		[Ordinal(1)] 
		[RED("itemOverrides")] 
		public CArray<workWorkspotItemOverrideItemOverride> ItemOverrides
		{
			get => GetProperty(ref _itemOverrides);
			set => SetProperty(ref _itemOverrides, value);
		}
	}
}

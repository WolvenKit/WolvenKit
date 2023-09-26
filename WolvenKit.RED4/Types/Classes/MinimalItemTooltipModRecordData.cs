using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MinimalItemTooltipModRecordData : MinimalItemTooltipModData
	{
		[Ordinal(0)] 
		[RED("dataPackage")] 
		public CHandle<gameUILocalizationDataPackage> DataPackage
		{
			get => GetPropertyValue<CHandle<gameUILocalizationDataPackage>>();
			set => SetPropertyValue<CHandle<gameUILocalizationDataPackage>>(value);
		}

		[Ordinal(1)] 
		[RED("description")] 
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("attunementData")] 
		public CHandle<MinimalItemTooltipModsAttunementData> AttunementData
		{
			get => GetPropertyValue<CHandle<MinimalItemTooltipModsAttunementData>>();
			set => SetPropertyValue<CHandle<MinimalItemTooltipModsAttunementData>>(value);
		}

		public MinimalItemTooltipModRecordData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

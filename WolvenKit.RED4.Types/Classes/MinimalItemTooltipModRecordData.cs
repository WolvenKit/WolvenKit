using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MinimalItemTooltipModRecordData : MinimalItemTooltipModData
	{
		private CHandle<gameUILocalizationDataPackage> _dataPackage;
		private CString _description;

		[Ordinal(0)] 
		[RED("dataPackage")] 
		public CHandle<gameUILocalizationDataPackage> DataPackage
		{
			get => GetProperty(ref _dataPackage);
			set => SetProperty(ref _dataPackage, value);
		}

		[Ordinal(1)] 
		[RED("description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}
	}
}

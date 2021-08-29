using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameInventoryItemAbility : RedBaseClass
	{
		private CName _iconPath;
		private CString _title;
		private CString _description;
		private CHandle<gameUILocalizationDataPackage> _localizationDataPackage;

		[Ordinal(0)] 
		[RED("IconPath")] 
		public CName IconPath
		{
			get => GetProperty(ref _iconPath);
			set => SetProperty(ref _iconPath, value);
		}

		[Ordinal(1)] 
		[RED("Title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(2)] 
		[RED("Description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(3)] 
		[RED("LocalizationDataPackage")] 
		public CHandle<gameUILocalizationDataPackage> LocalizationDataPackage
		{
			get => GetProperty(ref _localizationDataPackage);
			set => SetProperty(ref _localizationDataPackage, value);
		}
	}
}

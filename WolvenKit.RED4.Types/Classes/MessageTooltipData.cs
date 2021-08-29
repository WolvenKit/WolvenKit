using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MessageTooltipData : ATooltipData
	{
		private CString _title;
		private CString _description;
		private CHandle<gameUILocalizationDataPackage> _titleLocalizationPackage;
		private CHandle<gameUILocalizationDataPackage> _descriptionLocalizationPackage;

		[Ordinal(0)] 
		[RED("Title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(1)] 
		[RED("Description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(2)] 
		[RED("TitleLocalizationPackage")] 
		public CHandle<gameUILocalizationDataPackage> TitleLocalizationPackage
		{
			get => GetProperty(ref _titleLocalizationPackage);
			set => SetProperty(ref _titleLocalizationPackage, value);
		}

		[Ordinal(3)] 
		[RED("DescriptionLocalizationPackage")] 
		public CHandle<gameUILocalizationDataPackage> DescriptionLocalizationPackage
		{
			get => GetProperty(ref _descriptionLocalizationPackage);
			set => SetProperty(ref _descriptionLocalizationPackage, value);
		}
	}
}

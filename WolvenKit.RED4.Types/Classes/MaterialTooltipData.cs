using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MaterialTooltipData : ATooltipData
	{
		private CString _title;
		private CInt32 _baseMaterialQuantity;
		private CInt32 _materialQuantity;
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
		[RED("BaseMaterialQuantity")] 
		public CInt32 BaseMaterialQuantity
		{
			get => GetProperty(ref _baseMaterialQuantity);
			set => SetProperty(ref _baseMaterialQuantity, value);
		}

		[Ordinal(2)] 
		[RED("MaterialQuantity")] 
		public CInt32 MaterialQuantity
		{
			get => GetProperty(ref _materialQuantity);
			set => SetProperty(ref _materialQuantity, value);
		}

		[Ordinal(3)] 
		[RED("TitleLocalizationPackage")] 
		public CHandle<gameUILocalizationDataPackage> TitleLocalizationPackage
		{
			get => GetProperty(ref _titleLocalizationPackage);
			set => SetProperty(ref _titleLocalizationPackage, value);
		}

		[Ordinal(4)] 
		[RED("DescriptionLocalizationPackage")] 
		public CHandle<gameUILocalizationDataPackage> DescriptionLocalizationPackage
		{
			get => GetProperty(ref _descriptionLocalizationPackage);
			set => SetProperty(ref _descriptionLocalizationPackage, value);
		}
	}
}

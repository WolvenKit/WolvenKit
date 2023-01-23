using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MaterialTooltipData : ATooltipData
	{
		[Ordinal(0)] 
		[RED("Title")] 
		public CString Title
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("BaseMaterialQuantity")] 
		public CInt32 BaseMaterialQuantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("MaterialQuantity")] 
		public CInt32 MaterialQuantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("TitleLocalizationPackage")] 
		public CHandle<gameUILocalizationDataPackage> TitleLocalizationPackage
		{
			get => GetPropertyValue<CHandle<gameUILocalizationDataPackage>>();
			set => SetPropertyValue<CHandle<gameUILocalizationDataPackage>>(value);
		}

		[Ordinal(4)] 
		[RED("DescriptionLocalizationPackage")] 
		public CHandle<gameUILocalizationDataPackage> DescriptionLocalizationPackage
		{
			get => GetPropertyValue<CHandle<gameUILocalizationDataPackage>>();
			set => SetPropertyValue<CHandle<gameUILocalizationDataPackage>>(value);
		}

		public MaterialTooltipData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MessageTooltipData : ATooltipData
	{
		[Ordinal(0)] 
		[RED("Title")] 
		public CString Title
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("Description")] 
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("TitleLocalizationPackage")] 
		public CHandle<gameUILocalizationDataPackage> TitleLocalizationPackage
		{
			get => GetPropertyValue<CHandle<gameUILocalizationDataPackage>>();
			set => SetPropertyValue<CHandle<gameUILocalizationDataPackage>>(value);
		}

		[Ordinal(3)] 
		[RED("DescriptionLocalizationPackage")] 
		public CHandle<gameUILocalizationDataPackage> DescriptionLocalizationPackage
		{
			get => GetPropertyValue<CHandle<gameUILocalizationDataPackage>>();
			set => SetPropertyValue<CHandle<gameUILocalizationDataPackage>>(value);
		}

		public MessageTooltipData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

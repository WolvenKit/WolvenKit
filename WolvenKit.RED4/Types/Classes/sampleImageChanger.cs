using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class sampleImageChanger : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("imagePath")] 
		public CName ImagePath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("imageName_1")] 
		public CName ImageName_1
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("imageName_2")] 
		public CName ImageName_2
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("imageWidget")] 
		public CWeakHandle<inkImageWidget> ImageWidget
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		public sampleImageChanger()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

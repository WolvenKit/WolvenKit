using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class sampleImageChanger : inkWidgetLogicController
	{
		private CName _imagePath;
		private CName _imageName_1;
		private CName _imageName_2;
		private CWeakHandle<inkImageWidget> _imageWidget;

		[Ordinal(1)] 
		[RED("imagePath")] 
		public CName ImagePath
		{
			get => GetProperty(ref _imagePath);
			set => SetProperty(ref _imagePath, value);
		}

		[Ordinal(2)] 
		[RED("imageName_1")] 
		public CName ImageName_1
		{
			get => GetProperty(ref _imageName_1);
			set => SetProperty(ref _imageName_1, value);
		}

		[Ordinal(3)] 
		[RED("imageName_2")] 
		public CName ImageName_2
		{
			get => GetProperty(ref _imageName_2);
			set => SetProperty(ref _imageName_2, value);
		}

		[Ordinal(4)] 
		[RED("imageWidget")] 
		public CWeakHandle<inkImageWidget> ImageWidget
		{
			get => GetProperty(ref _imageWidget);
			set => SetProperty(ref _imageWidget, value);
		}
	}
}

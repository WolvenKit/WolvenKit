using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleImageChanger : inkWidgetLogicController
	{
		private CName _imagePath;
		private CName _imageName_1;
		private CName _imageName_2;
		private wCHandle<inkImageWidget> _imageWidget;

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
		public wCHandle<inkImageWidget> ImageWidget
		{
			get => GetProperty(ref _imageWidget);
			set => SetProperty(ref _imageWidget, value);
		}

		public sampleImageChanger(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

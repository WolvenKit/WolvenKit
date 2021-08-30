using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendRenderTextureBlobSizeInfo : RedBaseClass
	{
		private CUInt16 _width;
		private CUInt16 _height;
		private CUInt16 _depth;

		[Ordinal(0)] 
		[RED("width")] 
		public CUInt16 Width
		{
			get => GetProperty(ref _width);
			set => SetProperty(ref _width, value);
		}

		[Ordinal(1)] 
		[RED("height")] 
		public CUInt16 Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		[Ordinal(2)] 
		[RED("depth")] 
		public CUInt16 Depth
		{
			get => GetProperty(ref _depth);
			set => SetProperty(ref _depth, value);
		}

		public rendRenderTextureBlobSizeInfo()
		{
			_depth = 1;
		}
	}
}

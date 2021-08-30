using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CSourceTexture : ISerializable
	{
		private CUInt32 _width;
		private CUInt32 _height;
		private CUInt32 _depth;
		private CUInt32 _pitch;
		private CEnum<ETextureRawFormat> _format;

		[Ordinal(0)] 
		[RED("width")] 
		public CUInt32 Width
		{
			get => GetProperty(ref _width);
			set => SetProperty(ref _width, value);
		}

		[Ordinal(1)] 
		[RED("height")] 
		public CUInt32 Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		[Ordinal(2)] 
		[RED("depth")] 
		public CUInt32 Depth
		{
			get => GetProperty(ref _depth);
			set => SetProperty(ref _depth, value);
		}

		[Ordinal(3)] 
		[RED("pitch")] 
		public CUInt32 Pitch
		{
			get => GetProperty(ref _pitch);
			set => SetProperty(ref _pitch, value);
		}

		[Ordinal(4)] 
		[RED("format")] 
		public CEnum<ETextureRawFormat> Format
		{
			get => GetProperty(ref _format);
			set => SetProperty(ref _format, value);
		}

		public CSourceTexture()
		{
			_depth = 1;
			_format = new() { Value = Enums.ETextureRawFormat.TRF_TrueColor };
		}
	}
}

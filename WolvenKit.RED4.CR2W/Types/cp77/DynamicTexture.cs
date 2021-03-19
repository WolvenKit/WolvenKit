using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DynamicTexture : ITexture
	{
		private CUInt32 _width;
		private CUInt32 _height;
		private CBool _scaleToViewport;
		private CBool _mipChain;
		private CUInt8 _samplesCount;
		private CEnum<DynamicTextureDataFormat> _dataFormat;
		private CHandle<IDynamicTextureGenerator> _generator;

		[Ordinal(1)] 
		[RED("width")] 
		public CUInt32 Width
		{
			get => GetProperty(ref _width);
			set => SetProperty(ref _width, value);
		}

		[Ordinal(2)] 
		[RED("height")] 
		public CUInt32 Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		[Ordinal(3)] 
		[RED("scaleToViewport")] 
		public CBool ScaleToViewport
		{
			get => GetProperty(ref _scaleToViewport);
			set => SetProperty(ref _scaleToViewport, value);
		}

		[Ordinal(4)] 
		[RED("mipChain")] 
		public CBool MipChain
		{
			get => GetProperty(ref _mipChain);
			set => SetProperty(ref _mipChain, value);
		}

		[Ordinal(5)] 
		[RED("samplesCount")] 
		public CUInt8 SamplesCount
		{
			get => GetProperty(ref _samplesCount);
			set => SetProperty(ref _samplesCount, value);
		}

		[Ordinal(6)] 
		[RED("dataFormat")] 
		public CEnum<DynamicTextureDataFormat> DataFormat
		{
			get => GetProperty(ref _dataFormat);
			set => SetProperty(ref _dataFormat, value);
		}

		[Ordinal(7)] 
		[RED("generator")] 
		public CHandle<IDynamicTextureGenerator> Generator
		{
			get => GetProperty(ref _generator);
			set => SetProperty(ref _generator, value);
		}

		public DynamicTexture(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

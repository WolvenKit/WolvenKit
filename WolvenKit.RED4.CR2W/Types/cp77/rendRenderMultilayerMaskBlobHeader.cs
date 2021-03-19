using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendRenderMultilayerMaskBlobHeader : CVariable
	{
		private CUInt32 _version;
		private CUInt32 _atlasWidth;
		private CUInt32 _atlasHeight;
		private CUInt32 _numLayers;
		private CUInt32 _maskWidth;
		private CUInt32 _maskHeight;
		private CUInt32 _maskWidthLow;
		private CUInt32 _maskHeightLow;
		private CUInt32 _maskTileSize;
		private CUInt32 _flags;

		[Ordinal(0)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}

		[Ordinal(1)] 
		[RED("atlasWidth")] 
		public CUInt32 AtlasWidth
		{
			get => GetProperty(ref _atlasWidth);
			set => SetProperty(ref _atlasWidth, value);
		}

		[Ordinal(2)] 
		[RED("atlasHeight")] 
		public CUInt32 AtlasHeight
		{
			get => GetProperty(ref _atlasHeight);
			set => SetProperty(ref _atlasHeight, value);
		}

		[Ordinal(3)] 
		[RED("numLayers")] 
		public CUInt32 NumLayers
		{
			get => GetProperty(ref _numLayers);
			set => SetProperty(ref _numLayers, value);
		}

		[Ordinal(4)] 
		[RED("maskWidth")] 
		public CUInt32 MaskWidth
		{
			get => GetProperty(ref _maskWidth);
			set => SetProperty(ref _maskWidth, value);
		}

		[Ordinal(5)] 
		[RED("maskHeight")] 
		public CUInt32 MaskHeight
		{
			get => GetProperty(ref _maskHeight);
			set => SetProperty(ref _maskHeight, value);
		}

		[Ordinal(6)] 
		[RED("maskWidthLow")] 
		public CUInt32 MaskWidthLow
		{
			get => GetProperty(ref _maskWidthLow);
			set => SetProperty(ref _maskWidthLow, value);
		}

		[Ordinal(7)] 
		[RED("maskHeightLow")] 
		public CUInt32 MaskHeightLow
		{
			get => GetProperty(ref _maskHeightLow);
			set => SetProperty(ref _maskHeightLow, value);
		}

		[Ordinal(8)] 
		[RED("maskTileSize")] 
		public CUInt32 MaskTileSize
		{
			get => GetProperty(ref _maskTileSize);
			set => SetProperty(ref _maskTileSize, value);
		}

		[Ordinal(9)] 
		[RED("flags")] 
		public CUInt32 Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}

		public rendRenderMultilayerMaskBlobHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

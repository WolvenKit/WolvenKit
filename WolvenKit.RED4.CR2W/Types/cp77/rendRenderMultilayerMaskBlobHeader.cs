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
			get
			{
				if (_version == null)
				{
					_version = (CUInt32) CR2WTypeManager.Create("Uint32", "version", cr2w, this);
				}
				return _version;
			}
			set
			{
				if (_version == value)
				{
					return;
				}
				_version = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("atlasWidth")] 
		public CUInt32 AtlasWidth
		{
			get
			{
				if (_atlasWidth == null)
				{
					_atlasWidth = (CUInt32) CR2WTypeManager.Create("Uint32", "atlasWidth", cr2w, this);
				}
				return _atlasWidth;
			}
			set
			{
				if (_atlasWidth == value)
				{
					return;
				}
				_atlasWidth = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("atlasHeight")] 
		public CUInt32 AtlasHeight
		{
			get
			{
				if (_atlasHeight == null)
				{
					_atlasHeight = (CUInt32) CR2WTypeManager.Create("Uint32", "atlasHeight", cr2w, this);
				}
				return _atlasHeight;
			}
			set
			{
				if (_atlasHeight == value)
				{
					return;
				}
				_atlasHeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("numLayers")] 
		public CUInt32 NumLayers
		{
			get
			{
				if (_numLayers == null)
				{
					_numLayers = (CUInt32) CR2WTypeManager.Create("Uint32", "numLayers", cr2w, this);
				}
				return _numLayers;
			}
			set
			{
				if (_numLayers == value)
				{
					return;
				}
				_numLayers = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("maskWidth")] 
		public CUInt32 MaskWidth
		{
			get
			{
				if (_maskWidth == null)
				{
					_maskWidth = (CUInt32) CR2WTypeManager.Create("Uint32", "maskWidth", cr2w, this);
				}
				return _maskWidth;
			}
			set
			{
				if (_maskWidth == value)
				{
					return;
				}
				_maskWidth = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("maskHeight")] 
		public CUInt32 MaskHeight
		{
			get
			{
				if (_maskHeight == null)
				{
					_maskHeight = (CUInt32) CR2WTypeManager.Create("Uint32", "maskHeight", cr2w, this);
				}
				return _maskHeight;
			}
			set
			{
				if (_maskHeight == value)
				{
					return;
				}
				_maskHeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("maskWidthLow")] 
		public CUInt32 MaskWidthLow
		{
			get
			{
				if (_maskWidthLow == null)
				{
					_maskWidthLow = (CUInt32) CR2WTypeManager.Create("Uint32", "maskWidthLow", cr2w, this);
				}
				return _maskWidthLow;
			}
			set
			{
				if (_maskWidthLow == value)
				{
					return;
				}
				_maskWidthLow = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("maskHeightLow")] 
		public CUInt32 MaskHeightLow
		{
			get
			{
				if (_maskHeightLow == null)
				{
					_maskHeightLow = (CUInt32) CR2WTypeManager.Create("Uint32", "maskHeightLow", cr2w, this);
				}
				return _maskHeightLow;
			}
			set
			{
				if (_maskHeightLow == value)
				{
					return;
				}
				_maskHeightLow = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("maskTileSize")] 
		public CUInt32 MaskTileSize
		{
			get
			{
				if (_maskTileSize == null)
				{
					_maskTileSize = (CUInt32) CR2WTypeManager.Create("Uint32", "maskTileSize", cr2w, this);
				}
				return _maskTileSize;
			}
			set
			{
				if (_maskTileSize == value)
				{
					return;
				}
				_maskTileSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("flags")] 
		public CUInt32 Flags
		{
			get
			{
				if (_flags == null)
				{
					_flags = (CUInt32) CR2WTypeManager.Create("Uint32", "flags", cr2w, this);
				}
				return _flags;
			}
			set
			{
				if (_flags == value)
				{
					return;
				}
				_flags = value;
				PropertySet(this);
			}
		}

		public rendRenderMultilayerMaskBlobHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

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
			get
			{
				if (_width == null)
				{
					_width = (CUInt32) CR2WTypeManager.Create("Uint32", "width", cr2w, this);
				}
				return _width;
			}
			set
			{
				if (_width == value)
				{
					return;
				}
				_width = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("height")] 
		public CUInt32 Height
		{
			get
			{
				if (_height == null)
				{
					_height = (CUInt32) CR2WTypeManager.Create("Uint32", "height", cr2w, this);
				}
				return _height;
			}
			set
			{
				if (_height == value)
				{
					return;
				}
				_height = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("scaleToViewport")] 
		public CBool ScaleToViewport
		{
			get
			{
				if (_scaleToViewport == null)
				{
					_scaleToViewport = (CBool) CR2WTypeManager.Create("Bool", "scaleToViewport", cr2w, this);
				}
				return _scaleToViewport;
			}
			set
			{
				if (_scaleToViewport == value)
				{
					return;
				}
				_scaleToViewport = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("mipChain")] 
		public CBool MipChain
		{
			get
			{
				if (_mipChain == null)
				{
					_mipChain = (CBool) CR2WTypeManager.Create("Bool", "mipChain", cr2w, this);
				}
				return _mipChain;
			}
			set
			{
				if (_mipChain == value)
				{
					return;
				}
				_mipChain = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("samplesCount")] 
		public CUInt8 SamplesCount
		{
			get
			{
				if (_samplesCount == null)
				{
					_samplesCount = (CUInt8) CR2WTypeManager.Create("Uint8", "samplesCount", cr2w, this);
				}
				return _samplesCount;
			}
			set
			{
				if (_samplesCount == value)
				{
					return;
				}
				_samplesCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("dataFormat")] 
		public CEnum<DynamicTextureDataFormat> DataFormat
		{
			get
			{
				if (_dataFormat == null)
				{
					_dataFormat = (CEnum<DynamicTextureDataFormat>) CR2WTypeManager.Create("DynamicTextureDataFormat", "dataFormat", cr2w, this);
				}
				return _dataFormat;
			}
			set
			{
				if (_dataFormat == value)
				{
					return;
				}
				_dataFormat = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("generator")] 
		public CHandle<IDynamicTextureGenerator> Generator
		{
			get
			{
				if (_generator == null)
				{
					_generator = (CHandle<IDynamicTextureGenerator>) CR2WTypeManager.Create("handle:IDynamicTextureGenerator", "generator", cr2w, this);
				}
				return _generator;
			}
			set
			{
				if (_generator == value)
				{
					return;
				}
				_generator = value;
				PropertySet(this);
			}
		}

		public DynamicTexture(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

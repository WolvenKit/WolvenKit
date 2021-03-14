using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class STextureGroupSetup_ : CVariable
	{
		private CEnum<GpuWrapApieTextureGroup> _group;
		private CEnum<ETextureRawFormat> _rawFormat;
		private CEnum<ETextureCompression> _compression;
		private CBool _isStreamable;
		private CBool _hasMipchain;
		private CBool _isGamma;
		private CUInt8 _platformMipBiasPC;
		private CUInt8 _platformMipBiasConsole;
		private CBool _allowTextureDowngrade;

		[Ordinal(0)] 
		[RED("group")] 
		public CEnum<GpuWrapApieTextureGroup> Group
		{
			get
			{
				if (_group == null)
				{
					_group = (CEnum<GpuWrapApieTextureGroup>) CR2WTypeManager.Create("GpuWrapApieTextureGroup", "group", cr2w, this);
				}
				return _group;
			}
			set
			{
				if (_group == value)
				{
					return;
				}
				_group = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("rawFormat")] 
		public CEnum<ETextureRawFormat> RawFormat
		{
			get
			{
				if (_rawFormat == null)
				{
					_rawFormat = (CEnum<ETextureRawFormat>) CR2WTypeManager.Create("ETextureRawFormat", "rawFormat", cr2w, this);
				}
				return _rawFormat;
			}
			set
			{
				if (_rawFormat == value)
				{
					return;
				}
				_rawFormat = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("compression")] 
		public CEnum<ETextureCompression> Compression
		{
			get
			{
				if (_compression == null)
				{
					_compression = (CEnum<ETextureCompression>) CR2WTypeManager.Create("ETextureCompression", "compression", cr2w, this);
				}
				return _compression;
			}
			set
			{
				if (_compression == value)
				{
					return;
				}
				_compression = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isStreamable")] 
		public CBool IsStreamable
		{
			get
			{
				if (_isStreamable == null)
				{
					_isStreamable = (CBool) CR2WTypeManager.Create("Bool", "isStreamable", cr2w, this);
				}
				return _isStreamable;
			}
			set
			{
				if (_isStreamable == value)
				{
					return;
				}
				_isStreamable = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("hasMipchain")] 
		public CBool HasMipchain
		{
			get
			{
				if (_hasMipchain == null)
				{
					_hasMipchain = (CBool) CR2WTypeManager.Create("Bool", "hasMipchain", cr2w, this);
				}
				return _hasMipchain;
			}
			set
			{
				if (_hasMipchain == value)
				{
					return;
				}
				_hasMipchain = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isGamma")] 
		public CBool IsGamma
		{
			get
			{
				if (_isGamma == null)
				{
					_isGamma = (CBool) CR2WTypeManager.Create("Bool", "isGamma", cr2w, this);
				}
				return _isGamma;
			}
			set
			{
				if (_isGamma == value)
				{
					return;
				}
				_isGamma = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("platformMipBiasPC")] 
		public CUInt8 PlatformMipBiasPC
		{
			get
			{
				if (_platformMipBiasPC == null)
				{
					_platformMipBiasPC = (CUInt8) CR2WTypeManager.Create("Uint8", "platformMipBiasPC", cr2w, this);
				}
				return _platformMipBiasPC;
			}
			set
			{
				if (_platformMipBiasPC == value)
				{
					return;
				}
				_platformMipBiasPC = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("platformMipBiasConsole")] 
		public CUInt8 PlatformMipBiasConsole
		{
			get
			{
				if (_platformMipBiasConsole == null)
				{
					_platformMipBiasConsole = (CUInt8) CR2WTypeManager.Create("Uint8", "platformMipBiasConsole", cr2w, this);
				}
				return _platformMipBiasConsole;
			}
			set
			{
				if (_platformMipBiasConsole == value)
				{
					return;
				}
				_platformMipBiasConsole = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("allowTextureDowngrade")] 
		public CBool AllowTextureDowngrade
		{
			get
			{
				if (_allowTextureDowngrade == null)
				{
					_allowTextureDowngrade = (CBool) CR2WTypeManager.Create("Bool", "allowTextureDowngrade", cr2w, this);
				}
				return _allowTextureDowngrade;
			}
			set
			{
				if (_allowTextureDowngrade == value)
				{
					return;
				}
				_allowTextureDowngrade = value;
				PropertySet(this);
			}
		}

		public STextureGroupSetup_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

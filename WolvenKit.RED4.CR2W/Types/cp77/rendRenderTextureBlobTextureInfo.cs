using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendRenderTextureBlobTextureInfo : CVariable
	{
		private CEnum<GpuWrapApieTextureType> _type;
		private CUInt32 _textureDataSize;
		private CUInt32 _sliceSize;
		private CUInt32 _dataAlignment;
		private CUInt16 _sliceCount;
		private CUInt8 _mipCount;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<GpuWrapApieTextureType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<GpuWrapApieTextureType>) CR2WTypeManager.Create("GpuWrapApieTextureType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("textureDataSize")] 
		public CUInt32 TextureDataSize
		{
			get
			{
				if (_textureDataSize == null)
				{
					_textureDataSize = (CUInt32) CR2WTypeManager.Create("Uint32", "textureDataSize", cr2w, this);
				}
				return _textureDataSize;
			}
			set
			{
				if (_textureDataSize == value)
				{
					return;
				}
				_textureDataSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("sliceSize")] 
		public CUInt32 SliceSize
		{
			get
			{
				if (_sliceSize == null)
				{
					_sliceSize = (CUInt32) CR2WTypeManager.Create("Uint32", "sliceSize", cr2w, this);
				}
				return _sliceSize;
			}
			set
			{
				if (_sliceSize == value)
				{
					return;
				}
				_sliceSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("dataAlignment")] 
		public CUInt32 DataAlignment
		{
			get
			{
				if (_dataAlignment == null)
				{
					_dataAlignment = (CUInt32) CR2WTypeManager.Create("Uint32", "dataAlignment", cr2w, this);
				}
				return _dataAlignment;
			}
			set
			{
				if (_dataAlignment == value)
				{
					return;
				}
				_dataAlignment = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("sliceCount")] 
		public CUInt16 SliceCount
		{
			get
			{
				if (_sliceCount == null)
				{
					_sliceCount = (CUInt16) CR2WTypeManager.Create("Uint16", "sliceCount", cr2w, this);
				}
				return _sliceCount;
			}
			set
			{
				if (_sliceCount == value)
				{
					return;
				}
				_sliceCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("mipCount")] 
		public CUInt8 MipCount
		{
			get
			{
				if (_mipCount == null)
				{
					_mipCount = (CUInt8) CR2WTypeManager.Create("Uint8", "mipCount", cr2w, this);
				}
				return _mipCount;
			}
			set
			{
				if (_mipCount == value)
				{
					return;
				}
				_mipCount = value;
				PropertySet(this);
			}
		}

		public rendRenderTextureBlobTextureInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

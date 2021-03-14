using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CReflectionProbeDataResource : resStreamedResource
	{
		private DataBuffer _data;
		private rendRenderTextureResource _textureData;
		private CUInt64 _dataHash;
		private CBool _haveSkyData;
		private CArrayFixedSize<CFloat> _faceDepth;

		[Ordinal(1)] 
		[RED("data")] 
		public DataBuffer Data
		{
			get
			{
				if (_data == null)
				{
					_data = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("textureData")] 
		public rendRenderTextureResource TextureData
		{
			get
			{
				if (_textureData == null)
				{
					_textureData = (rendRenderTextureResource) CR2WTypeManager.Create("rendRenderTextureResource", "textureData", cr2w, this);
				}
				return _textureData;
			}
			set
			{
				if (_textureData == value)
				{
					return;
				}
				_textureData = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("dataHash")] 
		public CUInt64 DataHash
		{
			get
			{
				if (_dataHash == null)
				{
					_dataHash = (CUInt64) CR2WTypeManager.Create("Uint64", "dataHash", cr2w, this);
				}
				return _dataHash;
			}
			set
			{
				if (_dataHash == value)
				{
					return;
				}
				_dataHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("haveSkyData")] 
		public CBool HaveSkyData
		{
			get
			{
				if (_haveSkyData == null)
				{
					_haveSkyData = (CBool) CR2WTypeManager.Create("Bool", "haveSkyData", cr2w, this);
				}
				return _haveSkyData;
			}
			set
			{
				if (_haveSkyData == value)
				{
					return;
				}
				_haveSkyData = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("faceDepth", 6)] 
		public CArrayFixedSize<CFloat> FaceDepth
		{
			get
			{
				if (_faceDepth == null)
				{
					_faceDepth = (CArrayFixedSize<CFloat>) CR2WTypeManager.Create("[6]Float", "faceDepth", cr2w, this);
				}
				return _faceDepth;
			}
			set
			{
				if (_faceDepth == value)
				{
					return;
				}
				_faceDepth = value;
				PropertySet(this);
			}
		}

		public CReflectionProbeDataResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

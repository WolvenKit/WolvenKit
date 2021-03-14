using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendTopologyData : CVariable
	{
		private CArray<CUInt8> _data;
		private CArray<CUInt8> _metadata;
		private CUInt32 _dataStride;
		private CUInt32 _metadataStride;

		[Ordinal(0)] 
		[RED("data")] 
		public CArray<CUInt8> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CArray<CUInt8>) CR2WTypeManager.Create("array:Uint8", "data", cr2w, this);
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

		[Ordinal(1)] 
		[RED("metadata")] 
		public CArray<CUInt8> Metadata
		{
			get
			{
				if (_metadata == null)
				{
					_metadata = (CArray<CUInt8>) CR2WTypeManager.Create("array:Uint8", "metadata", cr2w, this);
				}
				return _metadata;
			}
			set
			{
				if (_metadata == value)
				{
					return;
				}
				_metadata = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("dataStride")] 
		public CUInt32 DataStride
		{
			get
			{
				if (_dataStride == null)
				{
					_dataStride = (CUInt32) CR2WTypeManager.Create("Uint32", "dataStride", cr2w, this);
				}
				return _dataStride;
			}
			set
			{
				if (_dataStride == value)
				{
					return;
				}
				_dataStride = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("metadataStride")] 
		public CUInt32 MetadataStride
		{
			get
			{
				if (_metadataStride == null)
				{
					_metadataStride = (CUInt32) CR2WTypeManager.Create("Uint32", "metadataStride", cr2w, this);
				}
				return _metadataStride;
			}
			set
			{
				if (_metadataStride == value)
				{
					return;
				}
				_metadataStride = value;
				PropertySet(this);
			}
		}

		public rendTopologyData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

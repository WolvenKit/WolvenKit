using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CGIDataResource : resStreamedResource
	{
		private serializationDeferredDataBuffer _data;
		private CUInt64 _sectorHash;

		[Ordinal(1)] 
		[RED("data")] 
		public serializationDeferredDataBuffer Data
		{
			get
			{
				if (_data == null)
				{
					_data = (serializationDeferredDataBuffer) CR2WTypeManager.Create("serializationDeferredDataBuffer", "data", cr2w, this);
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
		[RED("sectorHash")] 
		public CUInt64 SectorHash
		{
			get
			{
				if (_sectorHash == null)
				{
					_sectorHash = (CUInt64) CR2WTypeManager.Create("Uint64", "sectorHash", cr2w, this);
				}
				return _sectorHash;
			}
			set
			{
				if (_sectorHash == value)
				{
					return;
				}
				_sectorHash = value;
				PropertySet(this);
			}
		}

		public CGIDataResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

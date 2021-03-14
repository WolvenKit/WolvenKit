using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamBakedDestructionData : meshMeshParameter
	{
		private CArray<meshRegionData> _regionData;
		private CArray<DataBuffer> _indices;

		[Ordinal(0)] 
		[RED("regionData")] 
		public CArray<meshRegionData> RegionData
		{
			get
			{
				if (_regionData == null)
				{
					_regionData = (CArray<meshRegionData>) CR2WTypeManager.Create("array:meshRegionData", "regionData", cr2w, this);
				}
				return _regionData;
			}
			set
			{
				if (_regionData == value)
				{
					return;
				}
				_regionData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("indices")] 
		public CArray<DataBuffer> Indices
		{
			get
			{
				if (_indices == null)
				{
					_indices = (CArray<DataBuffer>) CR2WTypeManager.Create("array:DataBuffer", "indices", cr2w, this);
				}
				return _indices;
			}
			set
			{
				if (_indices == value)
				{
					return;
				}
				_indices = value;
				PropertySet(this);
			}
		}

		public meshMeshParamBakedDestructionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

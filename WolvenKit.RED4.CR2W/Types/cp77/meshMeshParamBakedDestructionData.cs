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
			get => GetProperty(ref _regionData);
			set => SetProperty(ref _regionData, value);
		}

		[Ordinal(1)] 
		[RED("indices")] 
		public CArray<DataBuffer> Indices
		{
			get => GetProperty(ref _indices);
			set => SetProperty(ref _indices, value);
		}

		public meshMeshParamBakedDestructionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

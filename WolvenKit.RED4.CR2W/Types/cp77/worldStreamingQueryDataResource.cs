using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStreamingQueryDataResource : CResource
	{
		private CArray<worldStreamingQueryRoadData> _roadDatas;
		private CArray<CUInt16> _connectedRoadDataIndices;

		[Ordinal(1)] 
		[RED("roadDatas")] 
		public CArray<worldStreamingQueryRoadData> RoadDatas
		{
			get => GetProperty(ref _roadDatas);
			set => SetProperty(ref _roadDatas, value);
		}

		[Ordinal(2)] 
		[RED("connectedRoadDataIndices")] 
		public CArray<CUInt16> ConnectedRoadDataIndices
		{
			get => GetProperty(ref _connectedRoadDataIndices);
			set => SetProperty(ref _connectedRoadDataIndices, value);
		}

		public worldStreamingQueryDataResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

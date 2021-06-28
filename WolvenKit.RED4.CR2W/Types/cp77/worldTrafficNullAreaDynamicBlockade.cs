using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficNullAreaDynamicBlockade : CVariable
	{
		private CUInt64 _areaID;
		private CArray<CUInt64> _offmeshLinks;
		private CArray<worldTrafficLaneUID> _affectedTrafficLanes;

		[Ordinal(0)] 
		[RED("areaID")] 
		public CUInt64 AreaID
		{
			get => GetProperty(ref _areaID);
			set => SetProperty(ref _areaID, value);
		}

		[Ordinal(1)] 
		[RED("offmeshLinks")] 
		public CArray<CUInt64> OffmeshLinks
		{
			get => GetProperty(ref _offmeshLinks);
			set => SetProperty(ref _offmeshLinks, value);
		}

		[Ordinal(2)] 
		[RED("affectedTrafficLanes")] 
		public CArray<worldTrafficLaneUID> AffectedTrafficLanes
		{
			get => GetProperty(ref _affectedTrafficLanes);
			set => SetProperty(ref _affectedTrafficLanes, value);
		}

		public worldTrafficNullAreaDynamicBlockade(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

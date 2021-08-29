using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficNullAreaDynamicBlockade : RedBaseClass
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
	}
}

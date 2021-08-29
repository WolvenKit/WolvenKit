using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficPersistentLaneConnections : RedBaseClass
	{
		private CArray<worldTrafficConnectivityOutLane> _outlanes;
		private CArray<worldTrafficConnectivityInLane> _inLanes;

		[Ordinal(0)] 
		[RED("outlanes")] 
		public CArray<worldTrafficConnectivityOutLane> Outlanes
		{
			get => GetProperty(ref _outlanes);
			set => SetProperty(ref _outlanes, value);
		}

		[Ordinal(1)] 
		[RED("inLanes")] 
		public CArray<worldTrafficConnectivityInLane> InLanes
		{
			get => GetProperty(ref _inLanes);
			set => SetProperty(ref _inLanes, value);
		}
	}
}

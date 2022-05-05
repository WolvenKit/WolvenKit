using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficPersistentLaneConnections : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("outlanes")] 
		public CArray<worldTrafficConnectivityOutLane> Outlanes
		{
			get => GetPropertyValue<CArray<worldTrafficConnectivityOutLane>>();
			set => SetPropertyValue<CArray<worldTrafficConnectivityOutLane>>(value);
		}

		[Ordinal(1)] 
		[RED("inLanes")] 
		public CArray<worldTrafficConnectivityInLane> InLanes
		{
			get => GetPropertyValue<CArray<worldTrafficConnectivityInLane>>();
			set => SetPropertyValue<CArray<worldTrafficConnectivityInLane>>(value);
		}

		public worldTrafficPersistentLaneConnections()
		{
			Outlanes = new();
			InLanes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

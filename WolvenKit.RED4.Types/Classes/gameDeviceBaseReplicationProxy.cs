using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameDeviceBaseReplicationProxy : netIEntityState
	{
		[Ordinal(2)] 
		[RED("scriptState")] 
		public CHandle<gameDeviceReplicatedState> ScriptState
		{
			get => GetPropertyValue<CHandle<gameDeviceReplicatedState>>();
			set => SetPropertyValue<CHandle<gameDeviceReplicatedState>>(value);
		}

		[Ordinal(3)] 
		[RED("versionId")] 
		public CUInt32 VersionId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("versionTimestamp")] 
		public netTime VersionTimestamp
		{
			get => GetPropertyValue<netTime>();
			set => SetPropertyValue<netTime>(value);
		}

		[Ordinal(5)] 
		[RED("initialOrientation")] 
		public EulerAngles InitialOrientation
		{
			get => GetPropertyValue<EulerAngles>();
			set => SetPropertyValue<EulerAngles>(value);
		}

		[Ordinal(6)] 
		[RED("initialLocation")] 
		public Vector3 InitialLocation
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public gameDeviceBaseReplicationProxy()
		{
			VersionTimestamp = new() { MilliSecs = 18446744073709551615 };
			InitialOrientation = new();
			InitialLocation = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

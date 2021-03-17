using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDeviceBaseReplicationProxy : netIEntityState
	{
		private CHandle<gameDeviceReplicatedState> _scriptState;
		private CUInt32 _versionId;
		private netTime _versionTimestamp;
		private EulerAngles _initialOrientation;
		private Vector3 _initialLocation;

		[Ordinal(2)] 
		[RED("scriptState")] 
		public CHandle<gameDeviceReplicatedState> ScriptState
		{
			get => GetProperty(ref _scriptState);
			set => SetProperty(ref _scriptState, value);
		}

		[Ordinal(3)] 
		[RED("versionId")] 
		public CUInt32 VersionId
		{
			get => GetProperty(ref _versionId);
			set => SetProperty(ref _versionId, value);
		}

		[Ordinal(4)] 
		[RED("versionTimestamp")] 
		public netTime VersionTimestamp
		{
			get => GetProperty(ref _versionTimestamp);
			set => SetProperty(ref _versionTimestamp, value);
		}

		[Ordinal(5)] 
		[RED("initialOrientation")] 
		public EulerAngles InitialOrientation
		{
			get => GetProperty(ref _initialOrientation);
			set => SetProperty(ref _initialOrientation, value);
		}

		[Ordinal(6)] 
		[RED("initialLocation")] 
		public Vector3 InitialLocation
		{
			get => GetProperty(ref _initialLocation);
			set => SetProperty(ref _initialLocation, value);
		}

		public gameDeviceBaseReplicationProxy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

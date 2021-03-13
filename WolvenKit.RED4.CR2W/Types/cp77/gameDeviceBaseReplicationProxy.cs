using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDeviceBaseReplicationProxy : netIEntityState
	{
		[Ordinal(2)] [RED("scriptState")] public CHandle<gameDeviceReplicatedState> ScriptState { get; set; }
		[Ordinal(3)] [RED("versionId")] public CUInt32 VersionId { get; set; }
		[Ordinal(4)] [RED("versionTimestamp")] public netTime VersionTimestamp { get; set; }
		[Ordinal(5)] [RED("initialOrientation")] public EulerAngles InitialOrientation { get; set; }
		[Ordinal(6)] [RED("initialLocation")] public Vector3 InitialLocation { get; set; }

		public gameDeviceBaseReplicationProxy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

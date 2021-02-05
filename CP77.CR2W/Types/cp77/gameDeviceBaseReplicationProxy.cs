using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameDeviceBaseReplicationProxy : netIEntityState
	{
		[Ordinal(0)]  [RED("scriptState")] public CHandle<gameDeviceReplicatedState> ScriptState { get; set; }
		[Ordinal(1)]  [RED("versionId")] public CUInt32 VersionId { get; set; }
		[Ordinal(2)]  [RED("versionTimestamp")] public netTime VersionTimestamp { get; set; }
		[Ordinal(3)]  [RED("initialOrientation")] public EulerAngles InitialOrientation { get; set; }
		[Ordinal(4)]  [RED("initialLocation")] public Vector3 InitialLocation { get; set; }

		public gameDeviceBaseReplicationProxy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

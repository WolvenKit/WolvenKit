using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameScanningComponentReplicatedState : netIComponentState
	{
		[Ordinal(0)]  [RED("controllingPeerIDs", 8)] public CStatic<netPeerID> ControllingPeerIDs { get; set; }
		[Ordinal(1)]  [RED("pctScanned")] public CFloat PctScanned { get; set; }
		[Ordinal(2)]  [RED("scanningState")] public CEnum<gameScanningState> ScanningState { get; set; }

		public gameScanningComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

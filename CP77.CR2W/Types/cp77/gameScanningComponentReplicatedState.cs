using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameScanningComponentReplicatedState : netIComponentState
	{
		[Ordinal(0)]  [RED("controllingPeerIDs")] public CStatic<8,netPeerID> ControllingPeerIDs { get; set; }
		[Ordinal(1)]  [RED("pctScanned")] public CFloat PctScanned { get; set; }
		[Ordinal(2)]  [RED("scanningState")] public CEnum<gameScanningState> ScanningState { get; set; }

		public gameScanningComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

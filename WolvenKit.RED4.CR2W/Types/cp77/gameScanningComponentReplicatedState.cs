using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameScanningComponentReplicatedState : netIComponentState
	{
		[Ordinal(2)] [RED("scanningState")] public CEnum<gameScanningState> ScanningState { get; set; }
		[Ordinal(3)] [RED("pctScanned")] public CFloat PctScanned { get; set; }
		[Ordinal(4)] [RED("controllingPeerIDs", 8)] public CStatic<netPeerID> ControllingPeerIDs { get; set; }

		public gameScanningComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

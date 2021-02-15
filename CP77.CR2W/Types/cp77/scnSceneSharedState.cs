using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnSceneSharedState : ISerializable
	{
		[Ordinal(0)] [RED("entrypoint")] public CName Entrypoint { get; set; }
		[Ordinal(1)] [RED("syncNodesVisited")] public CArray<scnSyncNodeSignal> SyncNodesVisited { get; set; }
		[Ordinal(2)] [RED("instanceHash")] public CUInt64 InstanceHash { get; set; }
		[Ordinal(3)] [RED("finishedOnServer")] public CBool FinishedOnServer { get; set; }
		[Ordinal(4)] [RED("finishedOnClient")] public CBool FinishedOnClient { get; set; }

		public scnSceneSharedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

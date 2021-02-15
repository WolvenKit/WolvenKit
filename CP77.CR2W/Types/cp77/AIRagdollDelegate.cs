using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIRagdollDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)] [RED("ragdollInstigator")] public wCHandle<gameObject> RagdollInstigator { get; set; }
		[Ordinal(1)] [RED("closestNavmeshPoint")] public Vector4 ClosestNavmeshPoint { get; set; }
		[Ordinal(2)] [RED("ragdollOutOfNavmesh")] public CBool RagdollOutOfNavmesh { get; set; }
		[Ordinal(3)] [RED("isUnderwater")] public CBool IsUnderwater { get; set; }
		[Ordinal(4)] [RED("poseAllowsRecovery")] public CBool PoseAllowsRecovery { get; set; }

		public AIRagdollDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questNPCLookAt_NodeType : questISceneManagerNodeType
	{
		[Ordinal(0)]  [RED("assignLookAt")] public CBool AssignLookAt { get; set; }
		[Ordinal(1)]  [RED("refPlayer")] public CBool RefPlayer { get; set; }
		[Ordinal(2)]  [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
		[Ordinal(3)]  [RED("lookAtTargetRef")] public gameEntityReference LookAtTargetRef { get; set; }

		public questNPCLookAt_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

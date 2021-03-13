using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questNPCLookAt_NodeType : questISceneManagerNodeType
	{
		[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
		[Ordinal(1)] [RED("lookAtTargetRef")] public gameEntityReference LookAtTargetRef { get; set; }
		[Ordinal(2)] [RED("assignLookAt")] public CBool AssignLookAt { get; set; }
		[Ordinal(3)] [RED("refPlayer")] public CBool RefPlayer { get; set; }

		public questNPCLookAt_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

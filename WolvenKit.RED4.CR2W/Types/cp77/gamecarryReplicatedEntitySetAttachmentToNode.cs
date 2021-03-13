using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamecarryReplicatedEntitySetAttachmentToNode : netEntityAttachmentInterface
	{
		[Ordinal(1)] [RED("localTransform")] public Transform LocalTransform { get; set; }

		public gamecarryReplicatedEntitySetAttachmentToNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

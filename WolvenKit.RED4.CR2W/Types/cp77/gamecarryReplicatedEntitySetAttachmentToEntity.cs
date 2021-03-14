using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamecarryReplicatedEntitySetAttachmentToEntity : netEntityAttachmentInterface
	{
		[Ordinal(1)] [RED("entity")] public wCHandle<entEntity> Entity { get; set; }
		[Ordinal(2)] [RED("slot")] public CName Slot { get; set; }
		[Ordinal(3)] [RED("localTransform")] public Transform LocalTransform { get; set; }

		public gamecarryReplicatedEntitySetAttachmentToEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

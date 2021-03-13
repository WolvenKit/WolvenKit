using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Window : Door
	{
		[Ordinal(135)] [RED("soloCollider")] public CHandle<entIComponent> SoloCollider { get; set; }
		[Ordinal(136)] [RED("strongSoloHandle")] public CHandle<entMeshComponent> StrongSoloHandle { get; set; }
		[Ordinal(137)] [RED("duplicateDestruction")] public CBool DuplicateDestruction { get; set; }

		public Window(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

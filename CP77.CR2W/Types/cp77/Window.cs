using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Window : Door
	{
		[Ordinal(0)]  [RED("duplicateDestruction")] public CBool DuplicateDestruction { get; set; }
		[Ordinal(1)]  [RED("soloCollider")] public CHandle<entIComponent> SoloCollider { get; set; }
		[Ordinal(2)]  [RED("strongSoloHandle")] public CHandle<entMeshComponent> StrongSoloHandle { get; set; }

		public Window(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

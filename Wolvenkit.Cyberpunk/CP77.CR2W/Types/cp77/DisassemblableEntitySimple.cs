using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DisassemblableEntitySimple : InteractiveDevice
	{
		[Ordinal(0)]  [RED("collider")] public CHandle<entIComponent> Collider { get; set; }
		[Ordinal(1)]  [RED("mesh")] public CHandle<entMeshComponent> Mesh { get; set; }

		public DisassemblableEntitySimple(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

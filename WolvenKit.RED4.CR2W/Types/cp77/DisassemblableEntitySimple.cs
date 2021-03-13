using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisassemblableEntitySimple : InteractiveDevice
	{
		[Ordinal(93)] [RED("mesh")] public CHandle<entMeshComponent> Mesh { get; set; }
		[Ordinal(94)] [RED("collider")] public CHandle<entIComponent> Collider { get; set; }

		public DisassemblableEntitySimple(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

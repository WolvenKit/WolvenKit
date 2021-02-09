using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VirtualItem_TEMP : gameObject
	{
		[Ordinal(31)]  [RED("item")] public CString Item { get; set; }
		[Ordinal(32)]  [RED("interaction")] public CHandle<gameinteractionsComponent> Interaction { get; set; }
		[Ordinal(33)]  [RED("mesh")] public CHandle<entPhysicalMeshComponent> Mesh { get; set; }
		[Ordinal(34)]  [RED("mesh1")] public CHandle<entPhysicalMeshComponent> Mesh1 { get; set; }
		[Ordinal(35)]  [RED("mesh2")] public CHandle<entPhysicalMeshComponent> Mesh2 { get; set; }
		[Ordinal(36)]  [RED("mesh3")] public CHandle<entPhysicalMeshComponent> Mesh3 { get; set; }
		[Ordinal(37)]  [RED("mesh4")] public CHandle<entPhysicalMeshComponent> Mesh4 { get; set; }

		public VirtualItem_TEMP(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

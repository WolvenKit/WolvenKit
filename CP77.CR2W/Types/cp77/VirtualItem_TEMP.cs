using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VirtualItem_TEMP : gameObject
	{
		[Ordinal(0)]  [RED("interaction")] public CHandle<gameinteractionsComponent> Interaction { get; set; }
		[Ordinal(1)]  [RED("item")] public CString Item { get; set; }
		[Ordinal(2)]  [RED("mesh")] public CHandle<entPhysicalMeshComponent> Mesh { get; set; }
		[Ordinal(3)]  [RED("mesh1")] public CHandle<entPhysicalMeshComponent> Mesh1 { get; set; }
		[Ordinal(4)]  [RED("mesh2")] public CHandle<entPhysicalMeshComponent> Mesh2 { get; set; }
		[Ordinal(5)]  [RED("mesh3")] public CHandle<entPhysicalMeshComponent> Mesh3 { get; set; }
		[Ordinal(6)]  [RED("mesh4")] public CHandle<entPhysicalMeshComponent> Mesh4 { get; set; }

		public VirtualItem_TEMP(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

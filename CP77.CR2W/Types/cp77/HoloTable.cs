using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HoloTable : InteractiveDevice
	{
		[Ordinal(84)]  [RED("meshTable")] public CArray<CHandle<entMeshComponent>> MeshTable { get; set; }
		[Ordinal(85)]  [RED("componentCounter")] public CInt32 ComponentCounter { get; set; }
		[Ordinal(86)]  [RED("currentMesh")] public CInt32 CurrentMesh { get; set; }
		[Ordinal(87)]  [RED("glitchMesh")] public CHandle<entMeshComponent> GlitchMesh { get; set; }

		public HoloTable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

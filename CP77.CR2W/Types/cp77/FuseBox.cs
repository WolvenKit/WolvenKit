using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FuseBox : InteractiveMasterDevice
	{
		[Ordinal(0)]  [RED("componentsOFF")] public CArray<CHandle<entIPlacedComponent>> ComponentsOFF { get; set; }
		[Ordinal(1)]  [RED("componentsON")] public CArray<CHandle<entIPlacedComponent>> ComponentsON { get; set; }
		[Ordinal(2)]  [RED("indexesOfComponentsToOFF")] public CArray<CInt32> IndexesOfComponentsToOFF { get; set; }
		[Ordinal(3)]  [RED("isShortGlitchActive")] public CBool IsShortGlitchActive { get; set; }
		[Ordinal(4)]  [RED("mesh")] public CHandle<entMeshComponent> Mesh { get; set; }
		[Ordinal(5)]  [RED("numberOfComponentsToOFF")] public CInt32 NumberOfComponentsToOFF { get; set; }
		[Ordinal(6)]  [RED("numberOfComponentsToON")] public CInt32 NumberOfComponentsToON { get; set; }
		[Ordinal(7)]  [RED("shortGlitchDelayID")] public gameDelayID ShortGlitchDelayID { get; set; }

		public FuseBox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

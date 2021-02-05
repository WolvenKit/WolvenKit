using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FuseBox : InteractiveMasterDevice
	{
		[Ordinal(84)]  [RED("isShortGlitchActive")] public CBool IsShortGlitchActive { get; set; }
		[Ordinal(85)]  [RED("shortGlitchDelayID")] public gameDelayID ShortGlitchDelayID { get; set; }
		[Ordinal(86)]  [RED("numberOfComponentsToON")] public CInt32 NumberOfComponentsToON { get; set; }
		[Ordinal(87)]  [RED("numberOfComponentsToOFF")] public CInt32 NumberOfComponentsToOFF { get; set; }
		[Ordinal(88)]  [RED("indexesOfComponentsToOFF")] public CArray<CInt32> IndexesOfComponentsToOFF { get; set; }
		[Ordinal(89)]  [RED("mesh")] public CHandle<entMeshComponent> Mesh { get; set; }
		[Ordinal(90)]  [RED("componentsON")] public CArray<CHandle<entIPlacedComponent>> ComponentsON { get; set; }
		[Ordinal(91)]  [RED("componentsOFF")] public CArray<CHandle<entIPlacedComponent>> ComponentsOFF { get; set; }

		public FuseBox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

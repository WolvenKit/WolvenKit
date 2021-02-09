using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Ref_4_1_2_StructureVariables : CVariable
	{
		[Ordinal(0)]  [RED("mul")] public CInt32 Mul { get; set; }
		[Ordinal(1)]  [RED("ti")] public CInt32 Ti { get; set; }
		[Ordinal(2)]  [RED("ple")] public CInt32 Ple { get; set; }
		[Ordinal(3)]  [RED("constVar")] public CInt32 ConstVar { get; set; }
		[Ordinal(4)]  [RED("editVar")] public CFloat EditVar { get; set; }
		[Ordinal(5)]  [RED("instEditVar")] public CFloat InstEditVar { get; set; }
		[Ordinal(6)]  [RED("inlinedVar")] public CArray<CInt32> InlinedVar { get; set; }
		[Ordinal(7)]  [RED("repVar")] public CInt32 RepVar { get; set; }
		[Ordinal(8)]  [RED("weakVar")] public wCHandle<IScriptable> WeakVar { get; set; }
		[Ordinal(9)]  [RED("persistentVar")] public CInt32 PersistentVar { get; set; }

		public Ref_4_1_2_StructureVariables(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

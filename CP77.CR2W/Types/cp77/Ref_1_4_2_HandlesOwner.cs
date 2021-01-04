using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Ref_1_4_2_HandlesOwner : CVariable
	{
		[Ordinal(0)]  [RED("obj")] public CHandle<Ref_1_4_2_Class> Obj { get; set; }
		[Ordinal(1)]  [RED("weakObj")] public wCHandle<Ref_1_4_2_Class> WeakObj { get; set; }

		public Ref_1_4_2_HandlesOwner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

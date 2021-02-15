using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Ref_1_3_1_NonTrivialClass : IScriptable
	{
		[Ordinal(0)] [RED("prop1")] public CFloat Prop1 { get; set; }
		[Ordinal(1)] [RED("prop2")] public CHandle<Ref_1_3_1_TrivialClass> Prop2 { get; set; }

		public Ref_1_3_1_NonTrivialClass(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

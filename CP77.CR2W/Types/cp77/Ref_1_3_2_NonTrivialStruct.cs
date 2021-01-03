using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Ref_1_3_2_NonTrivialStruct : CVariable
	{
		[Ordinal(0)]  [RED("prop1")] public CFloat Prop1 { get; set; }
		[Ordinal(1)]  [RED("prop2")] public Ref_1_3_2_TrivialStruct Prop2 { get; set; }

		public Ref_1_3_2_NonTrivialStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

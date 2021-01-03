using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Ref_1_3_2_DerivedStruct : Ref_1_3_2_NonTrivialStruct
	{
		[Ordinal(0)]  [RED("prop3")] public CBool Prop3 { get; set; }

		public Ref_1_3_2_DerivedStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

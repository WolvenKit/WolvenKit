using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Ref_1_3_2_2_DerivedStruct : Ref_1_3_2_2_BaseStruct
	{
		[Ordinal(0)]  [RED("prop2")] public CInt32 Prop2 { get; set; }

		public Ref_1_3_2_2_DerivedStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Ref_2_1_BaseClass : IScriptable
	{
		[Ordinal(0)]  [RED("prop1")] public CInt32 Prop1 { get; set; }
		[Ordinal(1)]  [RED("prop2")] public CInt32 Prop2 { get; set; }
		[Ordinal(2)]  [RED("prop3")] public CInt32 Prop3 { get; set; }

		public Ref_2_1_BaseClass(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

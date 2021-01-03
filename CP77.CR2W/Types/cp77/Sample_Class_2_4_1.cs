using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Sample_Class_2_4_1 : CVariable
	{
		[Ordinal(0)]  [RED("var0")] public CHandle<Sample_Class_2_4_0> Var0 { get; set; }

		public Sample_Class_2_4_1(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Sample_Class_2_8 : CVariable
	{
		[Ordinal(0)] [RED("array")] public CArray<CInt32> Array { get; set; }

		public Sample_Class_2_8(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

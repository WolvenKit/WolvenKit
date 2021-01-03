using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Sample_Class_2_8 : CVariable
	{
		[Ordinal(0)]  [RED("array")] public CArray<CInt32> Array { get; set; }

		public Sample_Class_2_8(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

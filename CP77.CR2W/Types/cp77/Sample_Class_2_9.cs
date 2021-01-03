using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Sample_Class_2_9 : CVariable
	{
		[Ordinal(0)]  [RED("bitField")] public Sample_Enum_As_Bitfield_2_9 BitField { get; set; }

		public Sample_Class_2_9(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

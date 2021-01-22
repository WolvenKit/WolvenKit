using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Ref_4_5_Browsable_Base : CVariable
	{
		[Ordinal(0)]  [RED("firstBaseVar")] public CInt32 FirstBaseVar { get; set; }
		[Ordinal(1)]  [RED("secondBaseVar")] public CInt32 SecondBaseVar { get; set; }
		[Ordinal(2)]  [RED("thirdBaseVar")] public CInt32 ThirdBaseVar { get; set; }

		public Ref_4_5_Browsable_Base(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

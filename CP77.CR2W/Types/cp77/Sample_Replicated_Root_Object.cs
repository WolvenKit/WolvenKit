using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Sample_Replicated_Root_Object : CVariable
	{
		[Ordinal(0)]  [RED("bool_")] public CBool Bool_ { get; set; }

		public Sample_Replicated_Root_Object(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

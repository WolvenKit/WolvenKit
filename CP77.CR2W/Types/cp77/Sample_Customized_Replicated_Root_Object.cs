using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Sample_Customized_Replicated_Root_Object : Sample_Replicated_Root_Object
	{
		[Ordinal(0)]  [RED("bool2")] public CBool Bool2 { get; set; }

		public Sample_Customized_Replicated_Root_Object(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

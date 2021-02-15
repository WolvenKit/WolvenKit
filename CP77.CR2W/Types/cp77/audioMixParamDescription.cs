using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioMixParamDescription : CVariable
	{
		[Ordinal(0)] [RED("parameter")] public CName Parameter { get; set; }
		[Ordinal(1)] [RED("defaultValue")] public CFloat DefaultValue { get; set; }

		public audioMixParamDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

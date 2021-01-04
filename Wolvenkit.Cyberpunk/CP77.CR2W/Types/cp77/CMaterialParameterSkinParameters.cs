using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterSkinParameters : CMaterialParameter
	{
		[Ordinal(0)]  [RED("skinProfile")] public rRef<CSkinProfile> SkinProfile { get; set; }

		public CMaterialParameterSkinParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

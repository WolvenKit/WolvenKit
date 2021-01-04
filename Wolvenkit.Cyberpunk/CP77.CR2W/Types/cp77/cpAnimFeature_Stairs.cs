using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class cpAnimFeature_Stairs : animAnimFeature
	{
		[Ordinal(0)]  [RED("onOff")] public CBool OnOff { get; set; }

		public cpAnimFeature_Stairs(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

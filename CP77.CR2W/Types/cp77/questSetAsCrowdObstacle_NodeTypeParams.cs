using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSetAsCrowdObstacle_NodeTypeParams : CVariable
	{
		[Ordinal(0)]  [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
		[Ordinal(1)]  [RED("enable")] public CBool Enable { get; set; }

		public questSetAsCrowdObstacle_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NetRunnerListItem : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("highlight")] public inkWidgetReference Highlight { get; set; }

		public NetRunnerListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

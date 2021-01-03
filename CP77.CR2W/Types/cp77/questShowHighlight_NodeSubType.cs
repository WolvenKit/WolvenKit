using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questShowHighlight_NodeSubType : questITutorial_NodeSubType
	{
		[Ordinal(0)]  [RED("enable")] public CBool Enable { get; set; }
		[Ordinal(1)]  [RED("entityReference")] public gameEntityReference EntityReference { get; set; }

		public questShowHighlight_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

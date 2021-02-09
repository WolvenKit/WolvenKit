using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BaseSubtitleLineLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("root")] public CHandle<inkWidget> Root { get; set; }
		[Ordinal(1)]  [RED("isKiroshiEnabled")] public CBool IsKiroshiEnabled { get; set; }
		[Ordinal(2)]  [RED("c_tier1_duration")] public CFloat C_tier1_duration { get; set; }
		[Ordinal(3)]  [RED("c_tier2_duration")] public CFloat C_tier2_duration { get; set; }

		public BaseSubtitleLineLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

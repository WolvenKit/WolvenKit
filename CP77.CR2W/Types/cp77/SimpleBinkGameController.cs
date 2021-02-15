using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SimpleBinkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] [RED("playCommonAd")] public CBool PlayCommonAd { get; set; }
		[Ordinal(17)] [RED("Video1Path")] public CName Video1Path { get; set; }
		[Ordinal(18)] [RED("Video2Path")] public CName Video2Path { get; set; }
		[Ordinal(19)] [RED("Video1")] public inkVideoWidgetReference Video1 { get; set; }
		[Ordinal(20)] [RED("Video2")] public inkVideoWidgetReference Video2 { get; set; }

		public SimpleBinkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

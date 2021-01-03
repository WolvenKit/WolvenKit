using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SimpleBinkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(0)]  [RED("Video1")] public inkVideoWidgetReference Video1 { get; set; }
		[Ordinal(1)]  [RED("Video1Path")] public CName Video1Path { get; set; }
		[Ordinal(2)]  [RED("Video2")] public inkVideoWidgetReference Video2 { get; set; }
		[Ordinal(3)]  [RED("Video2Path")] public CName Video2Path { get; set; }
		[Ordinal(4)]  [RED("playCommonAd")] public CBool PlayCommonAd { get; set; }

		public SimpleBinkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

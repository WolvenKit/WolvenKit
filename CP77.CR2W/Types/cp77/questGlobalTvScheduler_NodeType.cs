using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questGlobalTvScheduler_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] [RED("channelId")] public TweakDBID ChannelId { get; set; }
		[Ordinal(1)] [RED("overlayResource")] public raRef<inkWidgetLibraryResource> OverlayResource { get; set; }
		[Ordinal(2)] [RED("videoResource")] public raRef<Bink> VideoResource { get; set; }
		[Ordinal(3)] [RED("VOScene")] public raRef<scnSceneResource> VOScene { get; set; }
		[Ordinal(4)] [RED("audioEvent")] public CName AudioEvent { get; set; }
		[Ordinal(5)] [RED("newsTitleTweak")] public TweakDBID NewsTitleTweak { get; set; }
		[Ordinal(6)] [RED("randomNewsFeedPack")] public TweakDBID RandomNewsFeedPack { get; set; }

		public questGlobalTvScheduler_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questGlobalTvScheduler_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)]  [RED("VOScene")] public raRef<scnSceneResource> VOScene { get; set; }
		[Ordinal(1)]  [RED("audioEvent")] public CName AudioEvent { get; set; }
		[Ordinal(2)]  [RED("channelId")] public TweakDBID ChannelId { get; set; }
		[Ordinal(3)]  [RED("newsTitleTweak")] public TweakDBID NewsTitleTweak { get; set; }
		[Ordinal(4)]  [RED("overlayResource")] public raRef<inkWidgetLibraryResource> OverlayResource { get; set; }
		[Ordinal(5)]  [RED("randomNewsFeedPack")] public TweakDBID RandomNewsFeedPack { get; set; }
		[Ordinal(6)]  [RED("videoResource")] public raRef<Bink> VideoResource { get; set; }

		public questGlobalTvScheduler_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

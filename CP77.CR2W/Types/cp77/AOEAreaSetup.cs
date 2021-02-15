using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AOEAreaSetup : CVariable
	{
		[Ordinal(0)] [RED("areaEffect")] public TweakDBID AreaEffect { get; set; }
		[Ordinal(1)] [RED("actionName")] public TweakDBID ActionName { get; set; }
		[Ordinal(2)] [RED("blocksVisibility")] public CBool BlocksVisibility { get; set; }
		[Ordinal(3)] [RED("isDangerous")] public CBool IsDangerous { get; set; }
		[Ordinal(4)] [RED("activateOnStartup")] public CBool ActivateOnStartup { get; set; }
		[Ordinal(5)] [RED("effectsOnlyActiveInArea")] public CBool EffectsOnlyActiveInArea { get; set; }
		[Ordinal(6)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(7)] [RED("actionWidgetRecord")] public TweakDBID ActionWidgetRecord { get; set; }
		[Ordinal(8)] [RED("deviceWidgetRecord")] public TweakDBID DeviceWidgetRecord { get; set; }
		[Ordinal(9)] [RED("thumbnailWidgetRecord")] public TweakDBID ThumbnailWidgetRecord { get; set; }

		public AOEAreaSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

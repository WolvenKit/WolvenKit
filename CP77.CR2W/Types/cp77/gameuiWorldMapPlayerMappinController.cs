using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiWorldMapPlayerMappinController : gameuiBaseWorldMapMappinController
	{
		[Ordinal(0)]  [RED("animPlayerTrackedWidget")] public inkWidgetReference AnimPlayerTrackedWidget { get; set; }
		[Ordinal(1)]  [RED("animPlayerAboveBelowWidget")] public inkWidgetReference AnimPlayerAboveBelowWidget { get; set; }
		[Ordinal(2)]  [RED("taggedWidgets")] public CArray<inkWidgetReference> TaggedWidgets { get; set; }
		[Ordinal(3)]  [RED("isNewContainer")] public inkWidgetReference IsNewContainer { get; set; }
		[Ordinal(4)]  [RED("mappin")] public wCHandle<gamemappinsIMappin> Mappin { get; set; }
		[Ordinal(5)]  [RED("isCompletedPhase")] public CBool IsCompletedPhase { get; set; }
		[Ordinal(6)]  [RED("fadeAnim")] public CHandle<inkanimProxy> FadeAnim { get; set; }
		[Ordinal(7)]  [RED("selectAnim")] public CHandle<inkanimProxy> SelectAnim { get; set; }

		public gameuiWorldMapPlayerMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

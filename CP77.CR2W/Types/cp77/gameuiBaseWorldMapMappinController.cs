using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiBaseWorldMapMappinController : gameuiInteractionMappinController
	{
		[Ordinal(0)]  [RED("collectionCount")] public CUInt8 CollectionCount { get; set; }
		[Ordinal(1)]  [RED("fadeAnim")] public CHandle<inkanimProxy> FadeAnim { get; set; }
		[Ordinal(2)]  [RED("groupContainerWidget")] public inkWidgetReference GroupContainerWidget { get; set; }
		[Ordinal(3)]  [RED("groupCountTextWidget")] public inkTextWidgetReference GroupCountTextWidget { get; set; }
		[Ordinal(4)]  [RED("groupState")] public CEnum<gameuiMappinGroupState> GroupState { get; set; }
		[Ordinal(5)]  [RED("hasCustomFilter")] public CBool HasCustomFilter { get; set; }
		[Ordinal(6)]  [RED("inCustomFilter")] public CBool InCustomFilter { get; set; }
		[Ordinal(7)]  [RED("inZoomLevel")] public CBool InZoomLevel { get; set; }
		[Ordinal(8)]  [RED("isCompletedPhase")] public CBool IsCompletedPhase { get; set; }
		[Ordinal(9)]  [RED("isFastTravelEnabled")] public CBool IsFastTravelEnabled { get; set; }
		[Ordinal(10)]  [RED("isNewContainer")] public inkWidgetReference IsNewContainer { get; set; }
		[Ordinal(11)]  [RED("isVisibleInFilterAndZoom")] public CBool IsVisibleInFilterAndZoom { get; set; }
		[Ordinal(12)]  [RED("mappin")] public wCHandle<gamemappinsIMappin> Mappin { get; set; }
		[Ordinal(13)]  [RED("selectAnim")] public CHandle<inkanimProxy> SelectAnim { get; set; }
		[Ordinal(14)]  [RED("selected")] public CBool Selected { get; set; }

		public gameuiBaseWorldMapMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

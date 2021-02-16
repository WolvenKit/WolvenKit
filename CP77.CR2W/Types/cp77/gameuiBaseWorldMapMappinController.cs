using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiBaseWorldMapMappinController : gameuiInteractionMappinController
	{
		[Ordinal(11)] [RED("selected")] public CBool Selected { get; set; }
		[Ordinal(12)] [RED("inZoomLevel")] public CBool InZoomLevel { get; set; }
		[Ordinal(13)] [RED("inCustomFilter")] public CBool InCustomFilter { get; set; }
		[Ordinal(14)] [RED("hasCustomFilter")] public CBool HasCustomFilter { get; set; }
		[Ordinal(15)] [RED("isFastTravelEnabled")] public CBool IsFastTravelEnabled { get; set; }
		[Ordinal(16)] [RED("isVisibleInFilterAndZoom")] public CBool IsVisibleInFilterAndZoom { get; set; }
		[Ordinal(17)] [RED("groupState")] public CEnum<gameuiMappinGroupState> GroupState { get; set; }
		[Ordinal(18)] [RED("collectionCount")] public CUInt8 CollectionCount { get; set; }
		[Ordinal(19)] [RED("groupContainerWidget")] public inkWidgetReference GroupContainerWidget { get; set; }
		[Ordinal(20)] [RED("groupCountTextWidget")] public inkTextWidgetReference GroupCountTextWidget { get; set; }
		[Ordinal(21)] [RED("isNewContainer")] public inkWidgetReference IsNewContainer { get; set; }
		[Ordinal(22)] [RED("mappin")] public wCHandle<gamemappinsIMappin> Mappin { get; set; }
		[Ordinal(23)] [RED("isCompletedPhase")] public CBool IsCompletedPhase { get; set; }
		[Ordinal(24)] [RED("fadeAnim")] public CHandle<inkanimProxy> FadeAnim { get; set; }
		[Ordinal(25)] [RED("selectAnim")] public CHandle<inkanimProxy> SelectAnim { get; set; }

		public gameuiBaseWorldMapMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

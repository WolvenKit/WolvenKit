using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiWorldMapMenuGameController : gameuiMappinsContainerController
	{
		[Ordinal(0)]  [RED("selectedMappin")] public wCHandle<gameuiBaseWorldMapMappinController> SelectedMappin { get; set; }
		[Ordinal(1)]  [RED("isZoomToMappinEnabled")] public CBool IsZoomToMappinEnabled { get; set; }
		[Ordinal(2)]  [RED("canChangeCustomFilter")] public CBool CanChangeCustomFilter { get; set; }
		[Ordinal(3)]  [RED("settingsRecordID")] public TweakDBID SettingsRecordID { get; set; }
		[Ordinal(4)]  [RED("entityPreviewLibraryID")] public CName EntityPreviewLibraryID { get; set; }
		[Ordinal(5)]  [RED("entityPreviewSpawnContainer")] public inkCompoundWidgetReference EntityPreviewSpawnContainer { get; set; }
		[Ordinal(6)]  [RED("floorPlanSpawnContainer")] public inkCompoundWidgetReference FloorPlanSpawnContainer { get; set; }
		[Ordinal(7)]  [RED("compassWidget")] public inkWidgetReference CompassWidget { get; set; }
		[Ordinal(8)]  [RED("tooltipContainer")] public inkCompoundWidgetReference TooltipContainer { get; set; }
		[Ordinal(9)]  [RED("tooltipOffset")] public inkMargin TooltipOffset { get; set; }
		[Ordinal(10)]  [RED("tooltipDistrictOffset")] public inkMargin TooltipDistrictOffset { get; set; }
		[Ordinal(11)]  [RED("districtsContainer")] public inkCompoundWidgetReference DistrictsContainer { get; set; }
		[Ordinal(12)]  [RED("subdistrictsContainer")] public inkCompoundWidgetReference SubdistrictsContainer { get; set; }
		[Ordinal(13)]  [RED("playerOnTop")] public CBool PlayerOnTop { get; set; }
		[Ordinal(14)]  [RED("mappinOutlinesContainer")] public inkCompoundWidgetReference MappinOutlinesContainer { get; set; }
		[Ordinal(15)]  [RED("groupOutlinesContainer")] public inkCompoundWidgetReference GroupOutlinesContainer { get; set; }
		[Ordinal(16)]  [RED("hoveredDistrict")] public CEnum<gamedataDistrict> HoveredDistrict { get; set; }
		[Ordinal(17)]  [RED("hoveredSubDistrict")] public CEnum<gamedataDistrict> HoveredSubDistrict { get; set; }
		[Ordinal(18)]  [RED("selectedDistrict")] public CEnum<gamedataDistrict> SelectedDistrict { get; set; }
		[Ordinal(19)]  [RED("districtView")] public CEnum<gameuiEWorldMapDistrictView> DistrictView { get; set; }

		public gameuiWorldMapMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

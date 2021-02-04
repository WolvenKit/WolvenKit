using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapContainerController : gameuiMappinsContainerController
	{
		[Ordinal(0)]  [RED("visionRadiusVehicle")] public CFloat VisionRadiusVehicle { get; set; }
		[Ordinal(1)]  [RED("visionRadiusCombat")] public CFloat VisionRadiusCombat { get; set; }
		[Ordinal(2)]  [RED("visionRadiusQuestArea")] public CFloat VisionRadiusQuestArea { get; set; }
		[Ordinal(3)]  [RED("visionRadiusSecurityArea")] public CFloat VisionRadiusSecurityArea { get; set; }
		[Ordinal(4)]  [RED("visionRadiusInterior")] public CFloat VisionRadiusInterior { get; set; }
		[Ordinal(5)]  [RED("visionRadiusExterior")] public CFloat VisionRadiusExterior { get; set; }
		[Ordinal(6)]  [RED("clampedMappinContainer")] public inkCompoundWidgetReference ClampedMappinContainer { get; set; }
		[Ordinal(7)]  [RED("unclampedMappinContainer")] public inkCompoundWidgetReference UnclampedMappinContainer { get; set; }
		[Ordinal(8)]  [RED("maskWidget")] public inkMaskWidgetReference MaskWidget { get; set; }
		[Ordinal(9)]  [RED("playerIconWidget")] public inkWidgetReference PlayerIconWidget { get; set; }
		[Ordinal(10)]  [RED("compassWidget")] public inkWidgetReference CompassWidget { get; set; }
		[Ordinal(11)]  [RED("worldGeometryContainer")] public inkCanvasWidgetReference WorldGeometryContainer { get; set; }
		[Ordinal(12)]  [RED("worldGeometryCache")] public inkCacheWidgetReference WorldGeometryCache { get; set; }
		[Ordinal(13)]  [RED("geometryLibraryID")] public CName GeometryLibraryID { get; set; }
		[Ordinal(14)]  [RED("timeDisplayWidget")] public inkCompoundWidgetReference TimeDisplayWidget { get; set; }

		public gameuiMinimapContainerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

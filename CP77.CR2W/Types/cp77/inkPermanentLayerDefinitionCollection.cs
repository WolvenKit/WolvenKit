using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkPermanentLayerDefinitionCollection : CVariable
	{
		[Ordinal(0)] [RED("loadingLayer")] public inkLoadingLayerDefinition LoadingLayer { get; set; }
		[Ordinal(1)] [RED("watermarksLayer")] public inkWatermarksLayerDefinition WatermarksLayer { get; set; }
		[Ordinal(2)] [RED("sysNotificationsLayer")] public inkSystemNotificationsLayerDefinition SysNotificationsLayer { get; set; }

		public inkPermanentLayerDefinitionCollection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

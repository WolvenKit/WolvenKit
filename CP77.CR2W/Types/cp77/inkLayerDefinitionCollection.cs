using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkLayerDefinitionCollection : CVariable
	{
		[Ordinal(0)]  [RED("debugLayer")] public inkDebugLayerDefinition DebugLayer { get; set; }
		[Ordinal(1)]  [RED("gameNotificationsLayer")] public inkGameNotificationsLayerDefinition GameNotificationsLayer { get; set; }
		[Ordinal(2)]  [RED("hudLayer")] public inkHUDLayerDefinition HudLayer { get; set; }
		[Ordinal(3)]  [RED("menuLayer")] public inkMenuLayerDefinition MenuLayer { get; set; }
		[Ordinal(4)]  [RED("menuLayerMP")] public inkMenuLayerDefinition MenuLayerMP { get; set; }
		[Ordinal(5)]  [RED("offscreenLayer")] public inkOffscreenLayerDefinition OffscreenLayer { get; set; }
		[Ordinal(6)]  [RED("photoModeLayer")] public inkPhotoModeLayerDefinition PhotoModeLayer { get; set; }
		[Ordinal(7)]  [RED("videoLayer")] public inkVideoLayerDefinition VideoLayer { get; set; }

		public inkLayerDefinitionCollection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AreaEffectVisualizationComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("activeAction")] public CHandle<BaseScriptableAction> ActiveAction { get; set; }
		[Ordinal(1)]  [RED("activeEffectIndex")] public CInt32 ActiveEffectIndex { get; set; }
		[Ordinal(2)]  [RED("availableQuickHacks")] public CArray<CName> AvailableQuickHacks { get; set; }
		[Ordinal(3)]  [RED("availablespiderbotActions")] public CArray<CName> AvailablespiderbotActions { get; set; }
		[Ordinal(4)]  [RED("forceHighlightTargetBuckets")] public CArray<CHandle<GameEffectTargetVisualizationData>> ForceHighlightTargetBuckets { get; set; }
		[Ordinal(5)]  [RED("fxResourceMapper")] public CHandle<FxResourceMapperComponent> FxResourceMapper { get; set; }

		public AreaEffectVisualizationComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

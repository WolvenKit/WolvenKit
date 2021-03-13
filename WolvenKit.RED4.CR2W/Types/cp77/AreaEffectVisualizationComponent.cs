using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AreaEffectVisualizationComponent : gameScriptableComponent
	{
		[Ordinal(5)] [RED("fxResourceMapper")] public CHandle<FxResourceMapperComponent> FxResourceMapper { get; set; }
		[Ordinal(6)] [RED("forceHighlightTargetBuckets")] public CArray<CHandle<GameEffectTargetVisualizationData>> ForceHighlightTargetBuckets { get; set; }
		[Ordinal(7)] [RED("availableQuickHacks")] public CArray<CName> AvailableQuickHacks { get; set; }
		[Ordinal(8)] [RED("availablespiderbotActions")] public CArray<CName> AvailablespiderbotActions { get; set; }
		[Ordinal(9)] [RED("activeAction")] public CHandle<BaseScriptableAction> ActiveAction { get; set; }
		[Ordinal(10)] [RED("activeEffectIndex")] public CInt32 ActiveEffectIndex { get; set; }

		public AreaEffectVisualizationComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

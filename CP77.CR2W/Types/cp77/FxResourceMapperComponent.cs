using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FxResourceMapperComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("DEBUG_copiedDataFromEntity")] public CBool DEBUG_copiedDataFromEntity { get; set; }
		[Ordinal(1)]  [RED("DEBUG_copiedDataFromFXStruct")] public CBool DEBUG_copiedDataFromFXStruct { get; set; }
		[Ordinal(2)]  [RED("areaEffectData")] public CArray<CHandle<AreaEffectData>> AreaEffectData { get; set; }
		[Ordinal(3)]  [RED("areaEffectInFocusMode")] public CArray<CHandle<AreaEffectTargetData>> AreaEffectInFocusMode { get; set; }
		[Ordinal(4)]  [RED("areaEffectsData")] public CArray<SAreaEffectData> AreaEffectsData { get; set; }
		[Ordinal(5)]  [RED("areaEffectsInFocusMode")] public CArray<SAreaEffectTargetData> AreaEffectsInFocusMode { get; set; }
		[Ordinal(6)]  [RED("investigationSlotOffsetMultiplier")] public CFloat InvestigationSlotOffsetMultiplier { get; set; }

		public FxResourceMapperComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

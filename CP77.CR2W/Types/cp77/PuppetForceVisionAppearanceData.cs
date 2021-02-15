using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PuppetForceVisionAppearanceData : IScriptable
	{
		[Ordinal(0)] [RED("highlightType")] public CEnum<EFocusForcedHighlightType> HighlightType { get; set; }
		[Ordinal(1)] [RED("outlineType")] public CEnum<EFocusOutlineType> OutlineType { get; set; }
		[Ordinal(2)] [RED("stimRecord")] public wCHandle<gamedataStim_Record> StimRecord { get; set; }
		[Ordinal(3)] [RED("transitionTime")] public CFloat TransitionTime { get; set; }
		[Ordinal(4)] [RED("priority")] public CEnum<EPriority> Priority { get; set; }
		[Ordinal(5)] [RED("targets")] public CArray<wCHandle<ScriptedPuppet>> Targets { get; set; }
		[Ordinal(6)] [RED("highlightedTargets")] public CArray<wCHandle<ScriptedPuppet>> HighlightedTargets { get; set; }
		[Ordinal(7)] [RED("investigationSlots")] public CInt32 InvestigationSlots { get; set; }
		[Ordinal(8)] [RED("sourceHighlighted")] public CBool SourceHighlighted { get; set; }
		[Ordinal(9)] [RED("effectName")] public CString EffectName { get; set; }
		[Ordinal(10)] [RED("isInvalid")] public CBool IsInvalid { get; set; }

		public PuppetForceVisionAppearanceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

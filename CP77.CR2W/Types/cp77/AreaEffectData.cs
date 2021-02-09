using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AreaEffectData : IScriptable
	{
		[Ordinal(0)]  [RED("action")] public CHandle<ScriptableDeviceAction> Action { get; set; }
		[Ordinal(1)]  [RED("actionRecordID")] public TweakDBID ActionRecordID { get; set; }
		[Ordinal(2)]  [RED("areaEffectID")] public CName AreaEffectID { get; set; }
		[Ordinal(3)]  [RED("indicatorEffectName")] public CName IndicatorEffectName { get; set; }
		[Ordinal(4)]  [RED("useIndicatorEffect")] public CBool UseIndicatorEffect { get; set; }
		[Ordinal(5)]  [RED("indicatorEffectSize")] public CFloat IndicatorEffectSize { get; set; }
		[Ordinal(6)]  [RED("stimRange")] public CFloat StimRange { get; set; }
		[Ordinal(7)]  [RED("stimLifetime")] public CFloat StimLifetime { get; set; }
		[Ordinal(8)]  [RED("stimType")] public CEnum<DeviceStimType> StimType { get; set; }
		[Ordinal(9)]  [RED("stimSource")] public NodeRef StimSource { get; set; }
		[Ordinal(10)]  [RED("additionaStimSources")] public CArray<NodeRef> AdditionaStimSources { get; set; }
		[Ordinal(11)]  [RED("investigateSpot")] public NodeRef InvestigateSpot { get; set; }
		[Ordinal(12)]  [RED("investigateController")] public CBool InvestigateController { get; set; }
		[Ordinal(13)]  [RED("controllerSource")] public NodeRef ControllerSource { get; set; }
		[Ordinal(14)]  [RED("highlightTargets")] public CBool HighlightTargets { get; set; }
		[Ordinal(15)]  [RED("highlightType")] public CEnum<EFocusForcedHighlightType> HighlightType { get; set; }
		[Ordinal(16)]  [RED("outlineType")] public CEnum<EFocusOutlineType> OutlineType { get; set; }
		[Ordinal(17)]  [RED("highlightPriority")] public CEnum<EPriority> HighlightPriority { get; set; }
		[Ordinal(18)]  [RED("effectInstance")] public CHandle<gameEffectInstance> EffectInstance { get; set; }
		[Ordinal(19)]  [RED("gameEffectOverrideName")] public CName GameEffectOverrideName { get; set; }

		public AreaEffectData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

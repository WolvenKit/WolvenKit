using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SAreaEffectData : CVariable
	{
		[Ordinal(0)]  [RED("action")] public CHandle<ScriptableDeviceAction> Action { get; set; }
		[Ordinal(1)]  [RED("additionaStimSources")] public CArray<NodeRef> AdditionaStimSources { get; set; }
		[Ordinal(2)]  [RED("areaEffectID")] public CName AreaEffectID { get; set; }
		[Ordinal(3)]  [RED("controllerSource")] public NodeRef ControllerSource { get; set; }
		[Ordinal(4)]  [RED("effectInstance")] public CHandle<gameEffectInstance> EffectInstance { get; set; }
		[Ordinal(5)]  [RED("highlightPriority")] public CEnum<EPriority> HighlightPriority { get; set; }
		[Ordinal(6)]  [RED("highlightTargets")] public CBool HighlightTargets { get; set; }
		[Ordinal(7)]  [RED("highlightType")] public CEnum<EFocusForcedHighlightType> HighlightType { get; set; }
		[Ordinal(8)]  [RED("indicatorEffectName")] public CName IndicatorEffectName { get; set; }
		[Ordinal(9)]  [RED("indicatorEffectSize")] public CFloat IndicatorEffectSize { get; set; }
		[Ordinal(10)]  [RED("investigateController")] public CBool InvestigateController { get; set; }
		[Ordinal(11)]  [RED("investigateSpot")] public NodeRef InvestigateSpot { get; set; }
		[Ordinal(12)]  [RED("stimLifetime")] public CFloat StimLifetime { get; set; }
		[Ordinal(13)]  [RED("stimRange")] public CFloat StimRange { get; set; }
		[Ordinal(14)]  [RED("stimSource")] public NodeRef StimSource { get; set; }
		[Ordinal(15)]  [RED("stimType")] public CEnum<DeviceStimType> StimType { get; set; }
		[Ordinal(16)]  [RED("useIndicatorEffect")] public CBool UseIndicatorEffect { get; set; }

		public SAreaEffectData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

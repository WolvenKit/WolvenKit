using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animFacialEmotionTransitionBaked : CVariable
	{
		[Ordinal(0)]  [RED("customTransitionAnim")] public CName CustomTransitionAnim { get; set; }
		[Ordinal(1)]  [RED("facialKeyWeight")] public CFloat FacialKeyWeight { get; set; }
		[Ordinal(2)]  [RED("facialKey_Female")] public CName FacialKey_Female { get; set; }
		[Ordinal(3)]  [RED("facialKey_Male")] public CName FacialKey_Male { get; set; }
		[Ordinal(4)]  [RED("timeScale")] public CFloat TimeScale { get; set; }
		[Ordinal(5)]  [RED("toIdleFemale")] public CName ToIdleFemale { get; set; }
		[Ordinal(6)]  [RED("toIdleMale")] public CName ToIdleMale { get; set; }
		[Ordinal(7)]  [RED("toIdleNeckWeight")] public CFloat ToIdleNeckWeight { get; set; }
		[Ordinal(8)]  [RED("toIdleWeight")] public CFloat ToIdleWeight { get; set; }
		[Ordinal(9)]  [RED("transitionDuration")] public CFloat TransitionDuration { get; set; }
		[Ordinal(10)]  [RED("transitionType")] public CEnum<animFacialEmotionTransitionType> TransitionType { get; set; }

		public animFacialEmotionTransitionBaked(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeatureUpdateWorkspot : animAnimFeature
	{
		[Ordinal(0)]  [RED("animName")] public CName AnimName { get; set; }
		[Ordinal(1)]  [RED("recordID")] public CInt32 RecordID { get; set; }
		[Ordinal(2)]  [RED("updateCounter")] public CInt32 UpdateCounter { get; set; }
		[Ordinal(3)]  [RED("boolsAsFlags")] public CInt32 BoolsAsFlags { get; set; }
		[Ordinal(4)]  [RED("animBlendTime")] public CFloat AnimBlendTime { get; set; }
		[Ordinal(5)]  [RED("forcedBlendIn")] public CFloat ForcedBlendIn { get; set; }
		[Ordinal(6)]  [RED("forceAnimTime")] public CFloat ForceAnimTime { get; set; }
		[Ordinal(7)]  [RED("timeScale")] public CFloat TimeScale { get; set; }
		[Ordinal(8)]  [RED("animationStartTime")] public CDouble AnimationStartTime { get; set; }
		[Ordinal(9)]  [RED("isPaused")] public CBool IsPaused { get; set; }
		[Ordinal(10)]  [RED("isLooped")] public CBool IsLooped { get; set; }
		[Ordinal(11)]  [RED("isExitAnim")] public CBool IsExitAnim { get; set; }
		[Ordinal(12)]  [RED("enableMotion")] public CBool EnableMotion { get; set; }
		[Ordinal(13)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(14)]  [RED("isAnimValid")] public CBool IsAnimValid { get; set; }
		[Ordinal(15)]  [RED("slotNameHash")] public CInt32 SlotNameHash { get; set; }
		[Ordinal(16)]  [RED("facialKeyWeight")] public CFloat FacialKeyWeight { get; set; }
		[Ordinal(17)]  [RED("facialIdleAnimation")] public CName FacialIdleAnimation { get; set; }
		[Ordinal(18)]  [RED("facialIdleKeyAnimation")] public CName FacialIdleKeyAnimation { get; set; }
		[Ordinal(19)]  [RED("globalBlendDuration")] public CFloat GlobalBlendDuration { get; set; }
		[Ordinal(20)]  [RED("globalBlendIn")] public CBool GlobalBlendIn { get; set; }

		public animAnimFeatureUpdateWorkspot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

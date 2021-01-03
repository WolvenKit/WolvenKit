using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimFeatureUpdateWorkspot : animAnimFeature
	{
		[Ordinal(0)]  [RED("animBlendTime")] public CFloat AnimBlendTime { get; set; }
		[Ordinal(1)]  [RED("animName")] public CName AnimName { get; set; }
		[Ordinal(2)]  [RED("animationStartTime")] public Double AnimationStartTime { get; set; }
		[Ordinal(3)]  [RED("boolsAsFlags")] public CInt32 BoolsAsFlags { get; set; }
		[Ordinal(4)]  [RED("enableMotion")] public CBool EnableMotion { get; set; }
		[Ordinal(5)]  [RED("facialIdleAnimation")] public CName FacialIdleAnimation { get; set; }
		[Ordinal(6)]  [RED("facialIdleKeyAnimation")] public CName FacialIdleKeyAnimation { get; set; }
		[Ordinal(7)]  [RED("facialKeyWeight")] public CFloat FacialKeyWeight { get; set; }
		[Ordinal(8)]  [RED("forceAnimTime")] public CFloat ForceAnimTime { get; set; }
		[Ordinal(9)]  [RED("forcedBlendIn")] public CFloat ForcedBlendIn { get; set; }
		[Ordinal(10)]  [RED("globalBlendDuration")] public CFloat GlobalBlendDuration { get; set; }
		[Ordinal(11)]  [RED("globalBlendIn")] public CBool GlobalBlendIn { get; set; }
		[Ordinal(12)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(13)]  [RED("isAnimValid")] public CBool IsAnimValid { get; set; }
		[Ordinal(14)]  [RED("isExitAnim")] public CBool IsExitAnim { get; set; }
		[Ordinal(15)]  [RED("isLooped")] public CBool IsLooped { get; set; }
		[Ordinal(16)]  [RED("isPaused")] public CBool IsPaused { get; set; }
		[Ordinal(17)]  [RED("recordID")] public CInt32 RecordID { get; set; }
		[Ordinal(18)]  [RED("slotNameHash")] public CInt32 SlotNameHash { get; set; }
		[Ordinal(19)]  [RED("timeScale")] public CFloat TimeScale { get; set; }
		[Ordinal(20)]  [RED("updateCounter")] public CInt32 UpdateCounter { get; set; }

		public animAnimFeatureUpdateWorkspot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

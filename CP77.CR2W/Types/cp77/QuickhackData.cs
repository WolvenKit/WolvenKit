using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuickhackData : IScriptable
	{
		[Ordinal(0)]  [RED("ICELevel")] public CFloat ICELevel { get; set; }
		[Ordinal(1)]  [RED("ICELevelVisible")] public CBool ICELevelVisible { get; set; }
		[Ordinal(2)]  [RED("action")] public CHandle<BaseScriptableAction> Action { get; set; }
		[Ordinal(3)]  [RED("actionCompletionEffects")] public CArray<wCHandle<gamedataObjectActionEffect_Record>> ActionCompletionEffects { get; set; }
		[Ordinal(4)]  [RED("actionMatchesTarget")] public CBool ActionMatchesTarget { get; set; }
		[Ordinal(5)]  [RED("actionOwner")] public entEntityID ActionOwner { get; set; }
		[Ordinal(6)]  [RED("actionOwnerName")] public CName ActionOwnerName { get; set; }
		[Ordinal(7)]  [RED("actionState")] public CEnum<EActionInactivityReson> ActionState { get; set; }
		[Ordinal(8)]  [RED("category")] public wCHandle<gamedataHackCategory_Record> Category { get; set; }
		[Ordinal(9)]  [RED("cooldown")] public CFloat Cooldown { get; set; }
		[Ordinal(10)]  [RED("cooldownTweak")] public TweakDBID CooldownTweak { get; set; }
		[Ordinal(11)]  [RED("cost")] public CInt32 Cost { get; set; }
		[Ordinal(12)]  [RED("costRaw")] public CInt32 CostRaw { get; set; }
		[Ordinal(13)]  [RED("description")] public CString Description { get; set; }
		[Ordinal(14)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(15)]  [RED("icon")] public TweakDBID Icon { get; set; }
		[Ordinal(16)]  [RED("iconCategory")] public CName IconCategory { get; set; }
		[Ordinal(17)]  [RED("inactiveReason")] public CString InactiveReason { get; set; }
		[Ordinal(18)]  [RED("isInstant")] public CBool IsInstant { get; set; }
		[Ordinal(19)]  [RED("isLocked")] public CBool IsLocked { get; set; }
		[Ordinal(20)]  [RED("maxListSize")] public CInt32 MaxListSize { get; set; }
		[Ordinal(21)]  [RED("networkBreached")] public CBool NetworkBreached { get; set; }
		[Ordinal(22)]  [RED("quality")] public CInt32 Quality { get; set; }
		[Ordinal(23)]  [RED("title")] public CString Title { get; set; }
		[Ordinal(24)]  [RED("titleAlternative")] public CString TitleAlternative { get; set; }
		[Ordinal(25)]  [RED("type")] public CEnum<gamedataObjectActionType> Type { get; set; }
		[Ordinal(26)]  [RED("uploadTime")] public CFloat UploadTime { get; set; }
		[Ordinal(27)]  [RED("vulnerabilities")] public CArray<TweakDBID> Vulnerabilities { get; set; }

		public QuickhackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

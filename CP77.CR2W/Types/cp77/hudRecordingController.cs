using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class hudRecordingController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("root")] public wCHandle<inkCompoundWidget> Root { get; set; }
		[Ordinal(8)]  [RED("anim_intro")] public CHandle<inkanimProxy> Anim_intro { get; set; }
		[Ordinal(9)]  [RED("anim_outro")] public CHandle<inkanimProxy> Anim_outro { get; set; }
		[Ordinal(10)]  [RED("anim_loop")] public CHandle<inkanimProxy> Anim_loop { get; set; }
		[Ordinal(11)]  [RED("option_intro")] public inkanimPlaybackOptions Option_intro { get; set; }
		[Ordinal(12)]  [RED("option_loop")] public inkanimPlaybackOptions Option_loop { get; set; }
		[Ordinal(13)]  [RED("option_outro")] public inkanimPlaybackOptions Option_outro { get; set; }
		[Ordinal(14)]  [RED("factListener")] public CUInt32 FactListener { get; set; }

		public hudRecordingController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ChatterLineLogicController : BaseSubtitleLineLogicController
	{
		[Ordinal(5)] [RED("TextContainer")] public inkWidgetReference TextContainer { get; set; }
		[Ordinal(6)] [RED("speachBubble")] public inkWidgetReference SpeachBubble { get; set; }
		[Ordinal(7)] [RED("background")] public inkRectangleWidgetReference Background { get; set; }
		[Ordinal(8)] [RED("container_normal")] public inkWidgetReference Container_normal { get; set; }
		[Ordinal(9)] [RED("container_wide")] public inkWidgetReference Container_wide { get; set; }
		[Ordinal(10)] [RED("text_normal")] public inkTextWidgetReference Text_normal { get; set; }
		[Ordinal(11)] [RED("text_wide")] public inkTextWidgetReference Text_wide { get; set; }
		[Ordinal(12)] [RED("kiroshiAnimationCtrl_Normal")] public CHandle<inkTextKiroshiAnimationController> KiroshiAnimationCtrl_Normal { get; set; }
		[Ordinal(13)] [RED("kiroshiAnimationCtrl_Wide")] public CHandle<inkTextKiroshiAnimationController> KiroshiAnimationCtrl_Wide { get; set; }
		[Ordinal(14)] [RED("motherTongueCtrl_Normal")] public CHandle<inkTextMotherTongueController> MotherTongueCtrl_Normal { get; set; }
		[Ordinal(15)] [RED("motherTongueCtrl_Wide")] public CHandle<inkTextMotherTongueController> MotherTongueCtrl_Wide { get; set; }
		[Ordinal(16)] [RED("isNameplateVisible")] public CBool IsNameplateVisible { get; set; }
		[Ordinal(17)] [RED("nameplateEntityId")] public entEntityID NameplateEntityId { get; set; }
		[Ordinal(18)] [RED("nameplatHeightOffset")] public CFloat NameplatHeightOffset { get; set; }
		[Ordinal(19)] [RED("ownerId")] public entEntityID OwnerId { get; set; }
		[Ordinal(20)] [RED("c_ExtraWideTextWidth")] public CInt32 C_ExtraWideTextWidth { get; set; }
		[Ordinal(21)] [RED("rootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(22)] [RED("projection")] public CHandle<inkScreenProjection> Projection { get; set; }
		[Ordinal(23)] [RED("subtitlesMaxDistance")] public CFloat SubtitlesMaxDistance { get; set; }
		[Ordinal(24)] [RED("limitSubtitlesDistance")] public CBool LimitSubtitlesDistance { get; set; }

		public ChatterLineLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

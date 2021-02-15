using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class sampleUIAnimationController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("rotation_anim")] public CHandle<inkanimDefinition> Rotation_anim { get; set; }
		[Ordinal(2)] [RED("size_anim")] public CHandle<inkanimDefinition> Size_anim { get; set; }
		[Ordinal(3)] [RED("color_anim")] public CHandle<inkanimDefinition> Color_anim { get; set; }
		[Ordinal(4)] [RED("alpha_anim")] public CHandle<inkanimDefinition> Alpha_anim { get; set; }
		[Ordinal(5)] [RED("rotation_anim_proxy")] public CHandle<inkanimProxy> Rotation_anim_proxy { get; set; }
		[Ordinal(6)] [RED("size_anim_proxy")] public CHandle<inkanimProxy> Size_anim_proxy { get; set; }
		[Ordinal(7)] [RED("color_anim_proxy")] public CHandle<inkanimProxy> Color_anim_proxy { get; set; }
		[Ordinal(8)] [RED("alpha_anim_proxy")] public CHandle<inkanimProxy> Alpha_anim_proxy { get; set; }
		[Ordinal(9)] [RED("rotation_widget")] public wCHandle<inkWidget> Rotation_widget { get; set; }
		[Ordinal(10)] [RED("size_widget")] public wCHandle<inkWidget> Size_widget { get; set; }
		[Ordinal(11)] [RED("color_widget")] public wCHandle<inkWidget> Color_widget { get; set; }
		[Ordinal(12)] [RED("alpha_widget")] public wCHandle<inkWidget> Alpha_widget { get; set; }
		[Ordinal(13)] [RED("iteration_counter")] public CUInt32 Iteration_counter { get; set; }
		[Ordinal(14)] [RED("is_paused")] public CBool Is_paused { get; set; }
		[Ordinal(15)] [RED("is_stoped")] public CBool Is_stoped { get; set; }
		[Ordinal(16)] [RED("playReversed")] public CBool PlayReversed { get; set; }

		public sampleUIAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

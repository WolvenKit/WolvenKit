using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_CameraSceneMode : animAnimFeature
	{
		[Ordinal(0)] [RED("pitch_yaw_order")] public CFloat Pitch_yaw_order { get; set; }
		[Ordinal(1)] [RED("is_scene_mode")] public CFloat Is_scene_mode { get; set; }
		[Ordinal(2)] [RED("scene_settings_mode")] public CFloat Scene_settings_mode { get; set; }

		public AnimFeature_CameraSceneMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

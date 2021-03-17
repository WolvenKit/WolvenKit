using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_CameraSceneMode : animAnimFeature
	{
		private CFloat _pitch_yaw_order;
		private CFloat _is_scene_mode;
		private CFloat _scene_settings_mode;

		[Ordinal(0)] 
		[RED("pitch_yaw_order")] 
		public CFloat Pitch_yaw_order
		{
			get => GetProperty(ref _pitch_yaw_order);
			set => SetProperty(ref _pitch_yaw_order, value);
		}

		[Ordinal(1)] 
		[RED("is_scene_mode")] 
		public CFloat Is_scene_mode
		{
			get => GetProperty(ref _is_scene_mode);
			set => SetProperty(ref _is_scene_mode, value);
		}

		[Ordinal(2)] 
		[RED("scene_settings_mode")] 
		public CFloat Scene_settings_mode
		{
			get => GetProperty(ref _scene_settings_mode);
			set => SetProperty(ref _scene_settings_mode, value);
		}

		public AnimFeature_CameraSceneMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

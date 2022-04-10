using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_CameraSceneMode : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("pitch_yaw_order")] 
		public CFloat Pitch_yaw_order
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("is_scene_mode")] 
		public CFloat Is_scene_mode
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("scene_settings_mode")] 
		public CFloat Scene_settings_mode
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_CameraSceneMode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

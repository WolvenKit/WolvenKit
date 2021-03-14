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
			get
			{
				if (_pitch_yaw_order == null)
				{
					_pitch_yaw_order = (CFloat) CR2WTypeManager.Create("Float", "pitch_yaw_order", cr2w, this);
				}
				return _pitch_yaw_order;
			}
			set
			{
				if (_pitch_yaw_order == value)
				{
					return;
				}
				_pitch_yaw_order = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("is_scene_mode")] 
		public CFloat Is_scene_mode
		{
			get
			{
				if (_is_scene_mode == null)
				{
					_is_scene_mode = (CFloat) CR2WTypeManager.Create("Float", "is_scene_mode", cr2w, this);
				}
				return _is_scene_mode;
			}
			set
			{
				if (_is_scene_mode == value)
				{
					return;
				}
				_is_scene_mode = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("scene_settings_mode")] 
		public CFloat Scene_settings_mode
		{
			get
			{
				if (_scene_settings_mode == null)
				{
					_scene_settings_mode = (CFloat) CR2WTypeManager.Create("Float", "scene_settings_mode", cr2w, this);
				}
				return _scene_settings_mode;
			}
			set
			{
				if (_scene_settings_mode == value)
				{
					return;
				}
				_scene_settings_mode = value;
				PropertySet(this);
			}
		}

		public AnimFeature_CameraSceneMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

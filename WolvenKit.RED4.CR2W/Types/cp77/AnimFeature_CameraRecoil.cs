using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_CameraRecoil : animAnimFeature
	{
		private CFloat _backward_offset;
		private CFloat _side_offset;
		private CFloat _tilt_angle;
		private CFloat _yaw_angle;
		private CFloat _pitch_angle;
		private CFloat _translate_transform_speed;
		private CFloat _rotate_transform_speed;
		private CBool _is_offset;

		[Ordinal(0)] 
		[RED("backward_offset")] 
		public CFloat Backward_offset
		{
			get
			{
				if (_backward_offset == null)
				{
					_backward_offset = (CFloat) CR2WTypeManager.Create("Float", "backward_offset", cr2w, this);
				}
				return _backward_offset;
			}
			set
			{
				if (_backward_offset == value)
				{
					return;
				}
				_backward_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("side_offset")] 
		public CFloat Side_offset
		{
			get
			{
				if (_side_offset == null)
				{
					_side_offset = (CFloat) CR2WTypeManager.Create("Float", "side_offset", cr2w, this);
				}
				return _side_offset;
			}
			set
			{
				if (_side_offset == value)
				{
					return;
				}
				_side_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("tilt_angle")] 
		public CFloat Tilt_angle
		{
			get
			{
				if (_tilt_angle == null)
				{
					_tilt_angle = (CFloat) CR2WTypeManager.Create("Float", "tilt_angle", cr2w, this);
				}
				return _tilt_angle;
			}
			set
			{
				if (_tilt_angle == value)
				{
					return;
				}
				_tilt_angle = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("yaw_angle")] 
		public CFloat Yaw_angle
		{
			get
			{
				if (_yaw_angle == null)
				{
					_yaw_angle = (CFloat) CR2WTypeManager.Create("Float", "yaw_angle", cr2w, this);
				}
				return _yaw_angle;
			}
			set
			{
				if (_yaw_angle == value)
				{
					return;
				}
				_yaw_angle = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("pitch_angle")] 
		public CFloat Pitch_angle
		{
			get
			{
				if (_pitch_angle == null)
				{
					_pitch_angle = (CFloat) CR2WTypeManager.Create("Float", "pitch_angle", cr2w, this);
				}
				return _pitch_angle;
			}
			set
			{
				if (_pitch_angle == value)
				{
					return;
				}
				_pitch_angle = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("translate_transform_speed")] 
		public CFloat Translate_transform_speed
		{
			get
			{
				if (_translate_transform_speed == null)
				{
					_translate_transform_speed = (CFloat) CR2WTypeManager.Create("Float", "translate_transform_speed", cr2w, this);
				}
				return _translate_transform_speed;
			}
			set
			{
				if (_translate_transform_speed == value)
				{
					return;
				}
				_translate_transform_speed = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("rotate_transform_speed")] 
		public CFloat Rotate_transform_speed
		{
			get
			{
				if (_rotate_transform_speed == null)
				{
					_rotate_transform_speed = (CFloat) CR2WTypeManager.Create("Float", "rotate_transform_speed", cr2w, this);
				}
				return _rotate_transform_speed;
			}
			set
			{
				if (_rotate_transform_speed == value)
				{
					return;
				}
				_rotate_transform_speed = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("is_offset")] 
		public CBool Is_offset
		{
			get
			{
				if (_is_offset == null)
				{
					_is_offset = (CBool) CR2WTypeManager.Create("Bool", "is_offset", cr2w, this);
				}
				return _is_offset;
			}
			set
			{
				if (_is_offset == value)
				{
					return;
				}
				_is_offset = value;
				PropertySet(this);
			}
		}

		public AnimFeature_CameraRecoil(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

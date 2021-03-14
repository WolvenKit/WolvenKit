using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_CameraBodyOffset : animAnimFeature
	{
		private CFloat _lookat_pitch_forward_offset;
		private CFloat _lookat_pitch_forward_down_ratio;
		private CFloat _lookat_yaw_left_offset;
		private CFloat _lookat_yaw_left_up_offset;
		private CFloat _lookat_yaw_right_offset;
		private CFloat _lookat_yaw_right_up_offset;
		private CFloat _lookat_yaw_offset_active_angle;
		private CFloat _is_paralax;
		private CFloat _paralax_radius;
		private CFloat _paralax_forward_offset;
		private CFloat _lookat_offset_vertical;

		[Ordinal(0)] 
		[RED("lookat_pitch_forward_offset")] 
		public CFloat Lookat_pitch_forward_offset
		{
			get
			{
				if (_lookat_pitch_forward_offset == null)
				{
					_lookat_pitch_forward_offset = (CFloat) CR2WTypeManager.Create("Float", "lookat_pitch_forward_offset", cr2w, this);
				}
				return _lookat_pitch_forward_offset;
			}
			set
			{
				if (_lookat_pitch_forward_offset == value)
				{
					return;
				}
				_lookat_pitch_forward_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("lookat_pitch_forward_down_ratio")] 
		public CFloat Lookat_pitch_forward_down_ratio
		{
			get
			{
				if (_lookat_pitch_forward_down_ratio == null)
				{
					_lookat_pitch_forward_down_ratio = (CFloat) CR2WTypeManager.Create("Float", "lookat_pitch_forward_down_ratio", cr2w, this);
				}
				return _lookat_pitch_forward_down_ratio;
			}
			set
			{
				if (_lookat_pitch_forward_down_ratio == value)
				{
					return;
				}
				_lookat_pitch_forward_down_ratio = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("lookat_yaw_left_offset")] 
		public CFloat Lookat_yaw_left_offset
		{
			get
			{
				if (_lookat_yaw_left_offset == null)
				{
					_lookat_yaw_left_offset = (CFloat) CR2WTypeManager.Create("Float", "lookat_yaw_left_offset", cr2w, this);
				}
				return _lookat_yaw_left_offset;
			}
			set
			{
				if (_lookat_yaw_left_offset == value)
				{
					return;
				}
				_lookat_yaw_left_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("lookat_yaw_left_up_offset")] 
		public CFloat Lookat_yaw_left_up_offset
		{
			get
			{
				if (_lookat_yaw_left_up_offset == null)
				{
					_lookat_yaw_left_up_offset = (CFloat) CR2WTypeManager.Create("Float", "lookat_yaw_left_up_offset", cr2w, this);
				}
				return _lookat_yaw_left_up_offset;
			}
			set
			{
				if (_lookat_yaw_left_up_offset == value)
				{
					return;
				}
				_lookat_yaw_left_up_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("lookat_yaw_right_offset")] 
		public CFloat Lookat_yaw_right_offset
		{
			get
			{
				if (_lookat_yaw_right_offset == null)
				{
					_lookat_yaw_right_offset = (CFloat) CR2WTypeManager.Create("Float", "lookat_yaw_right_offset", cr2w, this);
				}
				return _lookat_yaw_right_offset;
			}
			set
			{
				if (_lookat_yaw_right_offset == value)
				{
					return;
				}
				_lookat_yaw_right_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("lookat_yaw_right_up_offset")] 
		public CFloat Lookat_yaw_right_up_offset
		{
			get
			{
				if (_lookat_yaw_right_up_offset == null)
				{
					_lookat_yaw_right_up_offset = (CFloat) CR2WTypeManager.Create("Float", "lookat_yaw_right_up_offset", cr2w, this);
				}
				return _lookat_yaw_right_up_offset;
			}
			set
			{
				if (_lookat_yaw_right_up_offset == value)
				{
					return;
				}
				_lookat_yaw_right_up_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("lookat_yaw_offset_active_angle")] 
		public CFloat Lookat_yaw_offset_active_angle
		{
			get
			{
				if (_lookat_yaw_offset_active_angle == null)
				{
					_lookat_yaw_offset_active_angle = (CFloat) CR2WTypeManager.Create("Float", "lookat_yaw_offset_active_angle", cr2w, this);
				}
				return _lookat_yaw_offset_active_angle;
			}
			set
			{
				if (_lookat_yaw_offset_active_angle == value)
				{
					return;
				}
				_lookat_yaw_offset_active_angle = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("is_paralax")] 
		public CFloat Is_paralax
		{
			get
			{
				if (_is_paralax == null)
				{
					_is_paralax = (CFloat) CR2WTypeManager.Create("Float", "is_paralax", cr2w, this);
				}
				return _is_paralax;
			}
			set
			{
				if (_is_paralax == value)
				{
					return;
				}
				_is_paralax = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("paralax_radius")] 
		public CFloat Paralax_radius
		{
			get
			{
				if (_paralax_radius == null)
				{
					_paralax_radius = (CFloat) CR2WTypeManager.Create("Float", "paralax_radius", cr2w, this);
				}
				return _paralax_radius;
			}
			set
			{
				if (_paralax_radius == value)
				{
					return;
				}
				_paralax_radius = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("paralax_forward_offset")] 
		public CFloat Paralax_forward_offset
		{
			get
			{
				if (_paralax_forward_offset == null)
				{
					_paralax_forward_offset = (CFloat) CR2WTypeManager.Create("Float", "paralax_forward_offset", cr2w, this);
				}
				return _paralax_forward_offset;
			}
			set
			{
				if (_paralax_forward_offset == value)
				{
					return;
				}
				_paralax_forward_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("lookat_offset_vertical")] 
		public CFloat Lookat_offset_vertical
		{
			get
			{
				if (_lookat_offset_vertical == null)
				{
					_lookat_offset_vertical = (CFloat) CR2WTypeManager.Create("Float", "lookat_offset_vertical", cr2w, this);
				}
				return _lookat_offset_vertical;
			}
			set
			{
				if (_lookat_offset_vertical == value)
				{
					return;
				}
				_lookat_offset_vertical = value;
				PropertySet(this);
			}
		}

		public AnimFeature_CameraBodyOffset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

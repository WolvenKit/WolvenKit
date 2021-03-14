using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimVariableQuaternion : animAnimVariable
	{
		private CFloat _roll;
		private CFloat _pitch;
		private CFloat _yaw;
		private Quaternion _default;

		[Ordinal(2)] 
		[RED("roll")] 
		public CFloat Roll
		{
			get
			{
				if (_roll == null)
				{
					_roll = (CFloat) CR2WTypeManager.Create("Float", "roll", cr2w, this);
				}
				return _roll;
			}
			set
			{
				if (_roll == value)
				{
					return;
				}
				_roll = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("pitch")] 
		public CFloat Pitch
		{
			get
			{
				if (_pitch == null)
				{
					_pitch = (CFloat) CR2WTypeManager.Create("Float", "pitch", cr2w, this);
				}
				return _pitch;
			}
			set
			{
				if (_pitch == value)
				{
					return;
				}
				_pitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("yaw")] 
		public CFloat Yaw
		{
			get
			{
				if (_yaw == null)
				{
					_yaw = (CFloat) CR2WTypeManager.Create("Float", "yaw", cr2w, this);
				}
				return _yaw;
			}
			set
			{
				if (_yaw == value)
				{
					return;
				}
				_yaw = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("default")] 
		public Quaternion Default
		{
			get
			{
				if (_default == null)
				{
					_default = (Quaternion) CR2WTypeManager.Create("Quaternion", "default", cr2w, this);
				}
				return _default;
			}
			set
			{
				if (_default == value)
				{
					return;
				}
				_default = value;
				PropertySet(this);
			}
		}

		public animAnimVariableQuaternion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

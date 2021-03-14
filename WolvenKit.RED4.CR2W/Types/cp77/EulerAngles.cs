using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EulerAngles : CVariable
	{
		private CFloat _pitch;
		private CFloat _yaw;
		private CFloat _roll;

		[Ordinal(0)] 
		[RED("Pitch")] 
		public CFloat Pitch
		{
			get
			{
				if (_pitch == null)
				{
					_pitch = (CFloat) CR2WTypeManager.Create("Float", "Pitch", cr2w, this);
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

		[Ordinal(1)] 
		[RED("Yaw")] 
		public CFloat Yaw
		{
			get
			{
				if (_yaw == null)
				{
					_yaw = (CFloat) CR2WTypeManager.Create("Float", "Yaw", cr2w, this);
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

		[Ordinal(2)] 
		[RED("Roll")] 
		public CFloat Roll
		{
			get
			{
				if (_roll == null)
				{
					_roll = (CFloat) CR2WTypeManager.Create("Float", "Roll", cr2w, this);
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

		public EulerAngles(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

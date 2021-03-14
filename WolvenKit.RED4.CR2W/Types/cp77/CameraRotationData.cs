using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CameraRotationData : CVariable
	{
		private CFloat _pitch;
		private CFloat _maxPitch;
		private CFloat _minPitch;
		private CFloat _yaw;
		private CFloat _maxYaw;
		private CFloat _minYaw;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("maxPitch")] 
		public CFloat MaxPitch
		{
			get
			{
				if (_maxPitch == null)
				{
					_maxPitch = (CFloat) CR2WTypeManager.Create("Float", "maxPitch", cr2w, this);
				}
				return _maxPitch;
			}
			set
			{
				if (_maxPitch == value)
				{
					return;
				}
				_maxPitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("minPitch")] 
		public CFloat MinPitch
		{
			get
			{
				if (_minPitch == null)
				{
					_minPitch = (CFloat) CR2WTypeManager.Create("Float", "minPitch", cr2w, this);
				}
				return _minPitch;
			}
			set
			{
				if (_minPitch == value)
				{
					return;
				}
				_minPitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("maxYaw")] 
		public CFloat MaxYaw
		{
			get
			{
				if (_maxYaw == null)
				{
					_maxYaw = (CFloat) CR2WTypeManager.Create("Float", "maxYaw", cr2w, this);
				}
				return _maxYaw;
			}
			set
			{
				if (_maxYaw == value)
				{
					return;
				}
				_maxYaw = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("minYaw")] 
		public CFloat MinYaw
		{
			get
			{
				if (_minYaw == null)
				{
					_minYaw = (CFloat) CR2WTypeManager.Create("Float", "minYaw", cr2w, this);
				}
				return _minYaw;
			}
			set
			{
				if (_minYaw == value)
				{
					return;
				}
				_minYaw = value;
				PropertySet(this);
			}
		}

		public CameraRotationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

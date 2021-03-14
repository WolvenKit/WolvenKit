using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsDeviceStartPlayerCameraControlEvent : redEvent
	{
		private wCHandle<gameObject> _playerController;
		private Vector4 _initialRotation;
		private CFloat _minYaw;
		private CFloat _maxYaw;
		private CFloat _minPitch;
		private CFloat _maxPitch;

		[Ordinal(0)] 
		[RED("playerController")] 
		public wCHandle<gameObject> PlayerController
		{
			get
			{
				if (_playerController == null)
				{
					_playerController = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "playerController", cr2w, this);
				}
				return _playerController;
			}
			set
			{
				if (_playerController == value)
				{
					return;
				}
				_playerController = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("initialRotation")] 
		public Vector4 InitialRotation
		{
			get
			{
				if (_initialRotation == null)
				{
					_initialRotation = (Vector4) CR2WTypeManager.Create("Vector4", "initialRotation", cr2w, this);
				}
				return _initialRotation;
			}
			set
			{
				if (_initialRotation == value)
				{
					return;
				}
				_initialRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		public gameeventsDeviceStartPlayerCameraControlEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

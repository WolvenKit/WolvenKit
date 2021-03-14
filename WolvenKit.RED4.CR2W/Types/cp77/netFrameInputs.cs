using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class netFrameInputs : CVariable
	{
		private CArray<netInputAction> _inputBuffer;
		private netTime _timestamp;
		private CFloat _cameraRotationYaw;
		private CFloat _cameraRotationPitch;
		private CFloat _lookAtRotationYaw;
		private CFloat _lookAtRotationPitch;
		private CFloat _timeDelta;

		[Ordinal(0)] 
		[RED("inputBuffer")] 
		public CArray<netInputAction> InputBuffer
		{
			get
			{
				if (_inputBuffer == null)
				{
					_inputBuffer = (CArray<netInputAction>) CR2WTypeManager.Create("array:netInputAction", "inputBuffer", cr2w, this);
				}
				return _inputBuffer;
			}
			set
			{
				if (_inputBuffer == value)
				{
					return;
				}
				_inputBuffer = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("timestamp")] 
		public netTime Timestamp
		{
			get
			{
				if (_timestamp == null)
				{
					_timestamp = (netTime) CR2WTypeManager.Create("netTime", "timestamp", cr2w, this);
				}
				return _timestamp;
			}
			set
			{
				if (_timestamp == value)
				{
					return;
				}
				_timestamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("cameraRotationYaw")] 
		public CFloat CameraRotationYaw
		{
			get
			{
				if (_cameraRotationYaw == null)
				{
					_cameraRotationYaw = (CFloat) CR2WTypeManager.Create("Float", "cameraRotationYaw", cr2w, this);
				}
				return _cameraRotationYaw;
			}
			set
			{
				if (_cameraRotationYaw == value)
				{
					return;
				}
				_cameraRotationYaw = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("cameraRotationPitch")] 
		public CFloat CameraRotationPitch
		{
			get
			{
				if (_cameraRotationPitch == null)
				{
					_cameraRotationPitch = (CFloat) CR2WTypeManager.Create("Float", "cameraRotationPitch", cr2w, this);
				}
				return _cameraRotationPitch;
			}
			set
			{
				if (_cameraRotationPitch == value)
				{
					return;
				}
				_cameraRotationPitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("lookAtRotationYaw")] 
		public CFloat LookAtRotationYaw
		{
			get
			{
				if (_lookAtRotationYaw == null)
				{
					_lookAtRotationYaw = (CFloat) CR2WTypeManager.Create("Float", "lookAtRotationYaw", cr2w, this);
				}
				return _lookAtRotationYaw;
			}
			set
			{
				if (_lookAtRotationYaw == value)
				{
					return;
				}
				_lookAtRotationYaw = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("lookAtRotationPitch")] 
		public CFloat LookAtRotationPitch
		{
			get
			{
				if (_lookAtRotationPitch == null)
				{
					_lookAtRotationPitch = (CFloat) CR2WTypeManager.Create("Float", "lookAtRotationPitch", cr2w, this);
				}
				return _lookAtRotationPitch;
			}
			set
			{
				if (_lookAtRotationPitch == value)
				{
					return;
				}
				_lookAtRotationPitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("timeDelta")] 
		public CFloat TimeDelta
		{
			get
			{
				if (_timeDelta == null)
				{
					_timeDelta = (CFloat) CR2WTypeManager.Create("Float", "timeDelta", cr2w, this);
				}
				return _timeDelta;
			}
			set
			{
				if (_timeDelta == value)
				{
					return;
				}
				_timeDelta = value;
				PropertySet(this);
			}
		}

		public netFrameInputs(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

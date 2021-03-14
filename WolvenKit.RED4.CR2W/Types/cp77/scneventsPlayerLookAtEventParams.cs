using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsPlayerLookAtEventParams : CVariable
	{
		private CName _slotName;
		private Vector3 _offsetPos;
		private CFloat _duration;
		private CBool _adjustPitch;
		private CBool _adjustYaw;
		private CBool _endOnTargetReached;
		private CBool _endOnCameraInputApplied;
		private CBool _endOnTimeExceeded;
		private CFloat _cameraInputMagToBreak;
		private CFloat _precision;
		private CFloat _maxDuration;
		private CBool _easeIn;
		private CBool _easeOut;

		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CName) CR2WTypeManager.Create("CName", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("offsetPos")] 
		public Vector3 OffsetPos
		{
			get
			{
				if (_offsetPos == null)
				{
					_offsetPos = (Vector3) CR2WTypeManager.Create("Vector3", "offsetPos", cr2w, this);
				}
				return _offsetPos;
			}
			set
			{
				if (_offsetPos == value)
				{
					return;
				}
				_offsetPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("adjustPitch")] 
		public CBool AdjustPitch
		{
			get
			{
				if (_adjustPitch == null)
				{
					_adjustPitch = (CBool) CR2WTypeManager.Create("Bool", "adjustPitch", cr2w, this);
				}
				return _adjustPitch;
			}
			set
			{
				if (_adjustPitch == value)
				{
					return;
				}
				_adjustPitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("adjustYaw")] 
		public CBool AdjustYaw
		{
			get
			{
				if (_adjustYaw == null)
				{
					_adjustYaw = (CBool) CR2WTypeManager.Create("Bool", "adjustYaw", cr2w, this);
				}
				return _adjustYaw;
			}
			set
			{
				if (_adjustYaw == value)
				{
					return;
				}
				_adjustYaw = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("endOnTargetReached")] 
		public CBool EndOnTargetReached
		{
			get
			{
				if (_endOnTargetReached == null)
				{
					_endOnTargetReached = (CBool) CR2WTypeManager.Create("Bool", "endOnTargetReached", cr2w, this);
				}
				return _endOnTargetReached;
			}
			set
			{
				if (_endOnTargetReached == value)
				{
					return;
				}
				_endOnTargetReached = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("endOnCameraInputApplied")] 
		public CBool EndOnCameraInputApplied
		{
			get
			{
				if (_endOnCameraInputApplied == null)
				{
					_endOnCameraInputApplied = (CBool) CR2WTypeManager.Create("Bool", "endOnCameraInputApplied", cr2w, this);
				}
				return _endOnCameraInputApplied;
			}
			set
			{
				if (_endOnCameraInputApplied == value)
				{
					return;
				}
				_endOnCameraInputApplied = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("endOnTimeExceeded")] 
		public CBool EndOnTimeExceeded
		{
			get
			{
				if (_endOnTimeExceeded == null)
				{
					_endOnTimeExceeded = (CBool) CR2WTypeManager.Create("Bool", "endOnTimeExceeded", cr2w, this);
				}
				return _endOnTimeExceeded;
			}
			set
			{
				if (_endOnTimeExceeded == value)
				{
					return;
				}
				_endOnTimeExceeded = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("cameraInputMagToBreak")] 
		public CFloat CameraInputMagToBreak
		{
			get
			{
				if (_cameraInputMagToBreak == null)
				{
					_cameraInputMagToBreak = (CFloat) CR2WTypeManager.Create("Float", "cameraInputMagToBreak", cr2w, this);
				}
				return _cameraInputMagToBreak;
			}
			set
			{
				if (_cameraInputMagToBreak == value)
				{
					return;
				}
				_cameraInputMagToBreak = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("precision")] 
		public CFloat Precision
		{
			get
			{
				if (_precision == null)
				{
					_precision = (CFloat) CR2WTypeManager.Create("Float", "precision", cr2w, this);
				}
				return _precision;
			}
			set
			{
				if (_precision == value)
				{
					return;
				}
				_precision = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("maxDuration")] 
		public CFloat MaxDuration
		{
			get
			{
				if (_maxDuration == null)
				{
					_maxDuration = (CFloat) CR2WTypeManager.Create("Float", "maxDuration", cr2w, this);
				}
				return _maxDuration;
			}
			set
			{
				if (_maxDuration == value)
				{
					return;
				}
				_maxDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("easeIn")] 
		public CBool EaseIn
		{
			get
			{
				if (_easeIn == null)
				{
					_easeIn = (CBool) CR2WTypeManager.Create("Bool", "easeIn", cr2w, this);
				}
				return _easeIn;
			}
			set
			{
				if (_easeIn == value)
				{
					return;
				}
				_easeIn = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("easeOut")] 
		public CBool EaseOut
		{
			get
			{
				if (_easeOut == null)
				{
					_easeOut = (CBool) CR2WTypeManager.Create("Bool", "easeOut", cr2w, this);
				}
				return _easeOut;
			}
			set
			{
				if (_easeOut == value)
				{
					return;
				}
				_easeOut = value;
				PropertySet(this);
			}
		}

		public scneventsPlayerLookAtEventParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

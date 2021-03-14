using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaimAssistAimRequest : CVariable
	{
		private CFloat _duration;
		private CBool _adjustPitch;
		private CBool _adjustYaw;
		private CBool _endOnTargetReached;
		private CBool _endOnCameraInputApplied;
		private CBool _endOnTimeExceeded;
		private CBool _endOnAimingStopped;
		private CFloat _cameraInputMagToBreak;
		private CFloat _precision;
		private CFloat _maxDuration;
		private CBool _easeIn;
		private CBool _easeOut;
		private CBool _checkRange;
		private Vector4 _lookAtTarget;
		private CBool _processAsInput;
		private CBool _bodyPartsTracking;
		private CFloat _bptMaxDot;
		private CFloat _bptMaxSwitches;
		private CFloat _bptMinInputMag;
		private CFloat _bptMinResetInputMag;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("endOnAimingStopped")] 
		public CBool EndOnAimingStopped
		{
			get
			{
				if (_endOnAimingStopped == null)
				{
					_endOnAimingStopped = (CBool) CR2WTypeManager.Create("Bool", "endOnAimingStopped", cr2w, this);
				}
				return _endOnAimingStopped;
			}
			set
			{
				if (_endOnAimingStopped == value)
				{
					return;
				}
				_endOnAimingStopped = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		[Ordinal(9)] 
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

		[Ordinal(10)] 
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

		[Ordinal(11)] 
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

		[Ordinal(12)] 
		[RED("checkRange")] 
		public CBool CheckRange
		{
			get
			{
				if (_checkRange == null)
				{
					_checkRange = (CBool) CR2WTypeManager.Create("Bool", "checkRange", cr2w, this);
				}
				return _checkRange;
			}
			set
			{
				if (_checkRange == value)
				{
					return;
				}
				_checkRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("lookAtTarget")] 
		public Vector4 LookAtTarget
		{
			get
			{
				if (_lookAtTarget == null)
				{
					_lookAtTarget = (Vector4) CR2WTypeManager.Create("Vector4", "lookAtTarget", cr2w, this);
				}
				return _lookAtTarget;
			}
			set
			{
				if (_lookAtTarget == value)
				{
					return;
				}
				_lookAtTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("processAsInput")] 
		public CBool ProcessAsInput
		{
			get
			{
				if (_processAsInput == null)
				{
					_processAsInput = (CBool) CR2WTypeManager.Create("Bool", "processAsInput", cr2w, this);
				}
				return _processAsInput;
			}
			set
			{
				if (_processAsInput == value)
				{
					return;
				}
				_processAsInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("bodyPartsTracking")] 
		public CBool BodyPartsTracking
		{
			get
			{
				if (_bodyPartsTracking == null)
				{
					_bodyPartsTracking = (CBool) CR2WTypeManager.Create("Bool", "bodyPartsTracking", cr2w, this);
				}
				return _bodyPartsTracking;
			}
			set
			{
				if (_bodyPartsTracking == value)
				{
					return;
				}
				_bodyPartsTracking = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("bptMaxDot")] 
		public CFloat BptMaxDot
		{
			get
			{
				if (_bptMaxDot == null)
				{
					_bptMaxDot = (CFloat) CR2WTypeManager.Create("Float", "bptMaxDot", cr2w, this);
				}
				return _bptMaxDot;
			}
			set
			{
				if (_bptMaxDot == value)
				{
					return;
				}
				_bptMaxDot = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("bptMaxSwitches")] 
		public CFloat BptMaxSwitches
		{
			get
			{
				if (_bptMaxSwitches == null)
				{
					_bptMaxSwitches = (CFloat) CR2WTypeManager.Create("Float", "bptMaxSwitches", cr2w, this);
				}
				return _bptMaxSwitches;
			}
			set
			{
				if (_bptMaxSwitches == value)
				{
					return;
				}
				_bptMaxSwitches = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("bptMinInputMag")] 
		public CFloat BptMinInputMag
		{
			get
			{
				if (_bptMinInputMag == null)
				{
					_bptMinInputMag = (CFloat) CR2WTypeManager.Create("Float", "bptMinInputMag", cr2w, this);
				}
				return _bptMinInputMag;
			}
			set
			{
				if (_bptMinInputMag == value)
				{
					return;
				}
				_bptMinInputMag = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("bptMinResetInputMag")] 
		public CFloat BptMinResetInputMag
		{
			get
			{
				if (_bptMinResetInputMag == null)
				{
					_bptMinResetInputMag = (CFloat) CR2WTypeManager.Create("Float", "bptMinResetInputMag", cr2w, this);
				}
				return _bptMinResetInputMag;
			}
			set
			{
				if (_bptMinResetInputMag == value)
				{
					return;
				}
				_bptMinResetInputMag = value;
				PropertySet(this);
			}
		}

		public gameaimAssistAimRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DetectionParameters : CVariable
	{
		private CBool _canDetectIntruders;
		private CFloat _timeToActionAfterSpot;
		private CFloat _overrideRootRotation;
		private CFloat _maxRotationAngle;
		private CFloat _pitchAngle;
		private CFloat _rotationSpeed;

		[Ordinal(0)] 
		[RED("canDetectIntruders")] 
		public CBool CanDetectIntruders
		{
			get
			{
				if (_canDetectIntruders == null)
				{
					_canDetectIntruders = (CBool) CR2WTypeManager.Create("Bool", "canDetectIntruders", cr2w, this);
				}
				return _canDetectIntruders;
			}
			set
			{
				if (_canDetectIntruders == value)
				{
					return;
				}
				_canDetectIntruders = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("timeToActionAfterSpot")] 
		public CFloat TimeToActionAfterSpot
		{
			get
			{
				if (_timeToActionAfterSpot == null)
				{
					_timeToActionAfterSpot = (CFloat) CR2WTypeManager.Create("Float", "timeToActionAfterSpot", cr2w, this);
				}
				return _timeToActionAfterSpot;
			}
			set
			{
				if (_timeToActionAfterSpot == value)
				{
					return;
				}
				_timeToActionAfterSpot = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("overrideRootRotation")] 
		public CFloat OverrideRootRotation
		{
			get
			{
				if (_overrideRootRotation == null)
				{
					_overrideRootRotation = (CFloat) CR2WTypeManager.Create("Float", "overrideRootRotation", cr2w, this);
				}
				return _overrideRootRotation;
			}
			set
			{
				if (_overrideRootRotation == value)
				{
					return;
				}
				_overrideRootRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("maxRotationAngle")] 
		public CFloat MaxRotationAngle
		{
			get
			{
				if (_maxRotationAngle == null)
				{
					_maxRotationAngle = (CFloat) CR2WTypeManager.Create("Float", "maxRotationAngle", cr2w, this);
				}
				return _maxRotationAngle;
			}
			set
			{
				if (_maxRotationAngle == value)
				{
					return;
				}
				_maxRotationAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("pitchAngle")] 
		public CFloat PitchAngle
		{
			get
			{
				if (_pitchAngle == null)
				{
					_pitchAngle = (CFloat) CR2WTypeManager.Create("Float", "pitchAngle", cr2w, this);
				}
				return _pitchAngle;
			}
			set
			{
				if (_pitchAngle == value)
				{
					return;
				}
				_pitchAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("rotationSpeed")] 
		public CFloat RotationSpeed
		{
			get
			{
				if (_rotationSpeed == null)
				{
					_rotationSpeed = (CFloat) CR2WTypeManager.Create("Float", "rotationSpeed", cr2w, this);
				}
				return _rotationSpeed;
			}
			set
			{
				if (_rotationSpeed == value)
				{
					return;
				}
				_rotationSpeed = value;
				PropertySet(this);
			}
		}

		public DetectionParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

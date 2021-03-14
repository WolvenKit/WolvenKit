using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SurveillanceCameraResaveData : CVariable
	{
		private CBool _shouldRotate;
		private CFloat _maxRotationAngle;
		private CFloat _pitchAngle;
		private CFloat _rotationSpeed;
		private CBool _canStreamVideo;
		private CBool _canDetectIntruders;
		private CBool _canBeControled;
		private CName _factOnFeedReceived;
		private CName _questFactOnDetection;

		[Ordinal(0)] 
		[RED("shouldRotate")] 
		public CBool ShouldRotate
		{
			get
			{
				if (_shouldRotate == null)
				{
					_shouldRotate = (CBool) CR2WTypeManager.Create("Bool", "shouldRotate", cr2w, this);
				}
				return _shouldRotate;
			}
			set
			{
				if (_shouldRotate == value)
				{
					return;
				}
				_shouldRotate = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("canStreamVideo")] 
		public CBool CanStreamVideo
		{
			get
			{
				if (_canStreamVideo == null)
				{
					_canStreamVideo = (CBool) CR2WTypeManager.Create("Bool", "canStreamVideo", cr2w, this);
				}
				return _canStreamVideo;
			}
			set
			{
				if (_canStreamVideo == value)
				{
					return;
				}
				_canStreamVideo = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("canBeControled")] 
		public CBool CanBeControled
		{
			get
			{
				if (_canBeControled == null)
				{
					_canBeControled = (CBool) CR2WTypeManager.Create("Bool", "canBeControled", cr2w, this);
				}
				return _canBeControled;
			}
			set
			{
				if (_canBeControled == value)
				{
					return;
				}
				_canBeControled = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("factOnFeedReceived")] 
		public CName FactOnFeedReceived
		{
			get
			{
				if (_factOnFeedReceived == null)
				{
					_factOnFeedReceived = (CName) CR2WTypeManager.Create("CName", "factOnFeedReceived", cr2w, this);
				}
				return _factOnFeedReceived;
			}
			set
			{
				if (_factOnFeedReceived == value)
				{
					return;
				}
				_factOnFeedReceived = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("questFactOnDetection")] 
		public CName QuestFactOnDetection
		{
			get
			{
				if (_questFactOnDetection == null)
				{
					_questFactOnDetection = (CName) CR2WTypeManager.Create("CName", "questFactOnDetection", cr2w, this);
				}
				return _questFactOnDetection;
			}
			set
			{
				if (_questFactOnDetection == value)
				{
					return;
				}
				_questFactOnDetection = value;
				PropertySet(this);
			}
		}

		public SurveillanceCameraResaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

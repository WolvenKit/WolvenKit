using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SurveillanceCamera : SensorDevice
	{
		private CHandle<entVirtualCameraComponent> _virtualCam;
		private CHandle<entIComponent> _cameraHead;
		private CHandle<entIComponent> _cameraHeadPhysics;
		private CHandle<entIComponent> _verticalDecal1;
		private CHandle<entIComponent> _verticalDecal2;
		private CBool _meshDestrSupport;
		private CBool _shouldRotate;
		private CBool _canStreamVideo;
		private CBool _canDetectIntruders;
		private CFloat _currentAngle;
		private CBool _rotateLeft;
		private Vector4 _targetPosition;
		private CName _factOnFeedReceived;
		private CName _questFactOnDetection;
		private CHandle<entLookAtAddEvent> _lookAtEvent;
		private CFloat _currentYawModifier;
		private CFloat _currentPitchModifier;

		[Ordinal(187)] 
		[RED("virtualCam")] 
		public CHandle<entVirtualCameraComponent> VirtualCam
		{
			get
			{
				if (_virtualCam == null)
				{
					_virtualCam = (CHandle<entVirtualCameraComponent>) CR2WTypeManager.Create("handle:entVirtualCameraComponent", "virtualCam", cr2w, this);
				}
				return _virtualCam;
			}
			set
			{
				if (_virtualCam == value)
				{
					return;
				}
				_virtualCam = value;
				PropertySet(this);
			}
		}

		[Ordinal(188)] 
		[RED("cameraHead")] 
		public CHandle<entIComponent> CameraHead
		{
			get
			{
				if (_cameraHead == null)
				{
					_cameraHead = (CHandle<entIComponent>) CR2WTypeManager.Create("handle:entIComponent", "cameraHead", cr2w, this);
				}
				return _cameraHead;
			}
			set
			{
				if (_cameraHead == value)
				{
					return;
				}
				_cameraHead = value;
				PropertySet(this);
			}
		}

		[Ordinal(189)] 
		[RED("cameraHeadPhysics")] 
		public CHandle<entIComponent> CameraHeadPhysics
		{
			get
			{
				if (_cameraHeadPhysics == null)
				{
					_cameraHeadPhysics = (CHandle<entIComponent>) CR2WTypeManager.Create("handle:entIComponent", "cameraHeadPhysics", cr2w, this);
				}
				return _cameraHeadPhysics;
			}
			set
			{
				if (_cameraHeadPhysics == value)
				{
					return;
				}
				_cameraHeadPhysics = value;
				PropertySet(this);
			}
		}

		[Ordinal(190)] 
		[RED("verticalDecal1")] 
		public CHandle<entIComponent> VerticalDecal1
		{
			get
			{
				if (_verticalDecal1 == null)
				{
					_verticalDecal1 = (CHandle<entIComponent>) CR2WTypeManager.Create("handle:entIComponent", "verticalDecal1", cr2w, this);
				}
				return _verticalDecal1;
			}
			set
			{
				if (_verticalDecal1 == value)
				{
					return;
				}
				_verticalDecal1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(191)] 
		[RED("verticalDecal2")] 
		public CHandle<entIComponent> VerticalDecal2
		{
			get
			{
				if (_verticalDecal2 == null)
				{
					_verticalDecal2 = (CHandle<entIComponent>) CR2WTypeManager.Create("handle:entIComponent", "verticalDecal2", cr2w, this);
				}
				return _verticalDecal2;
			}
			set
			{
				if (_verticalDecal2 == value)
				{
					return;
				}
				_verticalDecal2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(192)] 
		[RED("meshDestrSupport")] 
		public CBool MeshDestrSupport
		{
			get
			{
				if (_meshDestrSupport == null)
				{
					_meshDestrSupport = (CBool) CR2WTypeManager.Create("Bool", "meshDestrSupport", cr2w, this);
				}
				return _meshDestrSupport;
			}
			set
			{
				if (_meshDestrSupport == value)
				{
					return;
				}
				_meshDestrSupport = value;
				PropertySet(this);
			}
		}

		[Ordinal(193)] 
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

		[Ordinal(194)] 
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

		[Ordinal(195)] 
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

		[Ordinal(196)] 
		[RED("currentAngle")] 
		public CFloat CurrentAngle
		{
			get
			{
				if (_currentAngle == null)
				{
					_currentAngle = (CFloat) CR2WTypeManager.Create("Float", "currentAngle", cr2w, this);
				}
				return _currentAngle;
			}
			set
			{
				if (_currentAngle == value)
				{
					return;
				}
				_currentAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(197)] 
		[RED("rotateLeft")] 
		public CBool RotateLeft
		{
			get
			{
				if (_rotateLeft == null)
				{
					_rotateLeft = (CBool) CR2WTypeManager.Create("Bool", "rotateLeft", cr2w, this);
				}
				return _rotateLeft;
			}
			set
			{
				if (_rotateLeft == value)
				{
					return;
				}
				_rotateLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(198)] 
		[RED("targetPosition")] 
		public Vector4 TargetPosition
		{
			get
			{
				if (_targetPosition == null)
				{
					_targetPosition = (Vector4) CR2WTypeManager.Create("Vector4", "targetPosition", cr2w, this);
				}
				return _targetPosition;
			}
			set
			{
				if (_targetPosition == value)
				{
					return;
				}
				_targetPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(199)] 
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

		[Ordinal(200)] 
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

		[Ordinal(201)] 
		[RED("lookAtEvent")] 
		public CHandle<entLookAtAddEvent> LookAtEvent
		{
			get
			{
				if (_lookAtEvent == null)
				{
					_lookAtEvent = (CHandle<entLookAtAddEvent>) CR2WTypeManager.Create("handle:entLookAtAddEvent", "lookAtEvent", cr2w, this);
				}
				return _lookAtEvent;
			}
			set
			{
				if (_lookAtEvent == value)
				{
					return;
				}
				_lookAtEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(202)] 
		[RED("currentYawModifier")] 
		public CFloat CurrentYawModifier
		{
			get
			{
				if (_currentYawModifier == null)
				{
					_currentYawModifier = (CFloat) CR2WTypeManager.Create("Float", "currentYawModifier", cr2w, this);
				}
				return _currentYawModifier;
			}
			set
			{
				if (_currentYawModifier == value)
				{
					return;
				}
				_currentYawModifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(203)] 
		[RED("currentPitchModifier")] 
		public CFloat CurrentPitchModifier
		{
			get
			{
				if (_currentPitchModifier == null)
				{
					_currentPitchModifier = (CFloat) CR2WTypeManager.Create("Float", "currentPitchModifier", cr2w, this);
				}
				return _currentPitchModifier;
			}
			set
			{
				if (_currentPitchModifier == value)
				{
					return;
				}
				_currentPitchModifier = value;
				PropertySet(this);
			}
		}

		public SurveillanceCamera(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

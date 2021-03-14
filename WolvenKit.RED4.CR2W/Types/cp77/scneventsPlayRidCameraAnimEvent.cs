using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsPlayRidCameraAnimEvent : scnSceneEvent
	{
		private NodeRef _cameraRef;
		private CEnum<scneventsRidCameraPlacement> _cameraPlacement;
		private scneventsPlayAnimEventData _animData;
		private scnRidCameraAnimationSRRefId _animSRRefId;
		private scnMarker _animOriginMarker;
		private CBool _activateAsGameCamera;
		private CBool _controlRenderToTextureState;

		[Ordinal(6)] 
		[RED("cameraRef")] 
		public NodeRef CameraRef
		{
			get
			{
				if (_cameraRef == null)
				{
					_cameraRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "cameraRef", cr2w, this);
				}
				return _cameraRef;
			}
			set
			{
				if (_cameraRef == value)
				{
					return;
				}
				_cameraRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("cameraPlacement")] 
		public CEnum<scneventsRidCameraPlacement> CameraPlacement
		{
			get
			{
				if (_cameraPlacement == null)
				{
					_cameraPlacement = (CEnum<scneventsRidCameraPlacement>) CR2WTypeManager.Create("scneventsRidCameraPlacement", "cameraPlacement", cr2w, this);
				}
				return _cameraPlacement;
			}
			set
			{
				if (_cameraPlacement == value)
				{
					return;
				}
				_cameraPlacement = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("animData")] 
		public scneventsPlayAnimEventData AnimData
		{
			get
			{
				if (_animData == null)
				{
					_animData = (scneventsPlayAnimEventData) CR2WTypeManager.Create("scneventsPlayAnimEventData", "animData", cr2w, this);
				}
				return _animData;
			}
			set
			{
				if (_animData == value)
				{
					return;
				}
				_animData = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("animSRRefId")] 
		public scnRidCameraAnimationSRRefId AnimSRRefId
		{
			get
			{
				if (_animSRRefId == null)
				{
					_animSRRefId = (scnRidCameraAnimationSRRefId) CR2WTypeManager.Create("scnRidCameraAnimationSRRefId", "animSRRefId", cr2w, this);
				}
				return _animSRRefId;
			}
			set
			{
				if (_animSRRefId == value)
				{
					return;
				}
				_animSRRefId = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("animOriginMarker")] 
		public scnMarker AnimOriginMarker
		{
			get
			{
				if (_animOriginMarker == null)
				{
					_animOriginMarker = (scnMarker) CR2WTypeManager.Create("scnMarker", "animOriginMarker", cr2w, this);
				}
				return _animOriginMarker;
			}
			set
			{
				if (_animOriginMarker == value)
				{
					return;
				}
				_animOriginMarker = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("activateAsGameCamera")] 
		public CBool ActivateAsGameCamera
		{
			get
			{
				if (_activateAsGameCamera == null)
				{
					_activateAsGameCamera = (CBool) CR2WTypeManager.Create("Bool", "activateAsGameCamera", cr2w, this);
				}
				return _activateAsGameCamera;
			}
			set
			{
				if (_activateAsGameCamera == value)
				{
					return;
				}
				_activateAsGameCamera = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("controlRenderToTextureState")] 
		public CBool ControlRenderToTextureState
		{
			get
			{
				if (_controlRenderToTextureState == null)
				{
					_controlRenderToTextureState = (CBool) CR2WTypeManager.Create("Bool", "controlRenderToTextureState", cr2w, this);
				}
				return _controlRenderToTextureState;
			}
			set
			{
				if (_controlRenderToTextureState == value)
				{
					return;
				}
				_controlRenderToTextureState = value;
				PropertySet(this);
			}
		}

		public scneventsPlayRidCameraAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

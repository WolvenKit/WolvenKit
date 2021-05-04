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
			get => GetProperty(ref _cameraRef);
			set => SetProperty(ref _cameraRef, value);
		}

		[Ordinal(7)] 
		[RED("cameraPlacement")] 
		public CEnum<scneventsRidCameraPlacement> CameraPlacement
		{
			get => GetProperty(ref _cameraPlacement);
			set => SetProperty(ref _cameraPlacement, value);
		}

		[Ordinal(8)] 
		[RED("animData")] 
		public scneventsPlayAnimEventData AnimData
		{
			get => GetProperty(ref _animData);
			set => SetProperty(ref _animData, value);
		}

		[Ordinal(9)] 
		[RED("animSRRefId")] 
		public scnRidCameraAnimationSRRefId AnimSRRefId
		{
			get => GetProperty(ref _animSRRefId);
			set => SetProperty(ref _animSRRefId, value);
		}

		[Ordinal(10)] 
		[RED("animOriginMarker")] 
		public scnMarker AnimOriginMarker
		{
			get => GetProperty(ref _animOriginMarker);
			set => SetProperty(ref _animOriginMarker, value);
		}

		[Ordinal(11)] 
		[RED("activateAsGameCamera")] 
		public CBool ActivateAsGameCamera
		{
			get => GetProperty(ref _activateAsGameCamera);
			set => SetProperty(ref _activateAsGameCamera, value);
		}

		[Ordinal(12)] 
		[RED("controlRenderToTextureState")] 
		public CBool ControlRenderToTextureState
		{
			get => GetProperty(ref _controlRenderToTextureState);
			set => SetProperty(ref _controlRenderToTextureState, value);
		}

		public scneventsPlayRidCameraAnimEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

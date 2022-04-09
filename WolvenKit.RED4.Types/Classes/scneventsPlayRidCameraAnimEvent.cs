using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scneventsPlayRidCameraAnimEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("cameraRef")] 
		public NodeRef CameraRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(7)] 
		[RED("cameraPlacement")] 
		public CEnum<scneventsRidCameraPlacement> CameraPlacement
		{
			get => GetPropertyValue<CEnum<scneventsRidCameraPlacement>>();
			set => SetPropertyValue<CEnum<scneventsRidCameraPlacement>>(value);
		}

		[Ordinal(8)] 
		[RED("animData")] 
		public scneventsPlayAnimEventData AnimData
		{
			get => GetPropertyValue<scneventsPlayAnimEventData>();
			set => SetPropertyValue<scneventsPlayAnimEventData>(value);
		}

		[Ordinal(9)] 
		[RED("animSRRefId")] 
		public scnRidCameraAnimationSRRefId AnimSRRefId
		{
			get => GetPropertyValue<scnRidCameraAnimationSRRefId>();
			set => SetPropertyValue<scnRidCameraAnimationSRRefId>(value);
		}

		[Ordinal(10)] 
		[RED("animOriginMarker")] 
		public scnMarker AnimOriginMarker
		{
			get => GetPropertyValue<scnMarker>();
			set => SetPropertyValue<scnMarker>(value);
		}

		[Ordinal(11)] 
		[RED("activateAsGameCamera")] 
		public CBool ActivateAsGameCamera
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("controlRenderToTextureState")] 
		public CBool ControlRenderToTextureState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("markCamerCut")] 
		public CBool MarkCamerCut
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scneventsPlayRidCameraAnimEvent()
		{
			Id = new() { Id = 18446744073709551615 };
			AnimData = new() { Stretch = 1.000000F, BlendInCurve = Enums.scnEasingType.SinusoidalEaseInOut, BlendOutCurve = Enums.scnEasingType.SinusoidalEaseInOut };
			AnimSRRefId = new() { Id = 4294967295 };
			AnimOriginMarker = new() { Type = Enums.scnMarkerType.Global, EntityRef = new() { Names = new() }, IsMounted = true };
			ActivateAsGameCamera = true;
			MarkCamerCut = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scneventsCameraPlacementEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("cameraRef")] 
		public NodeRef CameraRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(7)] 
		[RED("cameraTransformLS")] 
		public Transform CameraTransformLS
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		public scneventsCameraPlacementEvent()
		{
			Id = new scnSceneEventId();
			CameraTransformLS = new Transform();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

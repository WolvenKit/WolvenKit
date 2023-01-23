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
			Id = new() { Id = 18446744073709551615 };
			CameraTransformLS = new() { Position = new(), Orientation = new() { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

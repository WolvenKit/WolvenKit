using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scneventsCameraPlacementEvent : scnSceneEvent
	{
		private NodeRef _cameraRef;
		private Transform _cameraTransformLS;

		[Ordinal(6)] 
		[RED("cameraRef")] 
		public NodeRef CameraRef
		{
			get => GetProperty(ref _cameraRef);
			set => SetProperty(ref _cameraRef, value);
		}

		[Ordinal(7)] 
		[RED("cameraTransformLS")] 
		public Transform CameraTransformLS
		{
			get => GetProperty(ref _cameraTransformLS);
			set => SetProperty(ref _cameraTransformLS, value);
		}
	}
}

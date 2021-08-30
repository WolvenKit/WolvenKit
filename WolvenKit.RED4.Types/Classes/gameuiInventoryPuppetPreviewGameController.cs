using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiInventoryPuppetPreviewGameController : gameuiPuppetPreviewGameController
	{
		private CName _sceneName;
		private NodeRef _cameraRef;
		private inkWidgetReference _collider;
		private CBool _rotationIsMouseDown;
		private CFloat _maxMousePointerOffset;
		private CFloat _mouseRotationSpeed;

		[Ordinal(8)] 
		[RED("sceneName")] 
		public CName SceneName
		{
			get => GetProperty(ref _sceneName);
			set => SetProperty(ref _sceneName, value);
		}

		[Ordinal(9)] 
		[RED("cameraRef")] 
		public NodeRef CameraRef
		{
			get => GetProperty(ref _cameraRef);
			set => SetProperty(ref _cameraRef, value);
		}

		[Ordinal(10)] 
		[RED("collider")] 
		public inkWidgetReference Collider
		{
			get => GetProperty(ref _collider);
			set => SetProperty(ref _collider, value);
		}

		[Ordinal(11)] 
		[RED("rotationIsMouseDown")] 
		public CBool RotationIsMouseDown
		{
			get => GetProperty(ref _rotationIsMouseDown);
			set => SetProperty(ref _rotationIsMouseDown, value);
		}

		[Ordinal(12)] 
		[RED("maxMousePointerOffset")] 
		public CFloat MaxMousePointerOffset
		{
			get => GetProperty(ref _maxMousePointerOffset);
			set => SetProperty(ref _maxMousePointerOffset, value);
		}

		[Ordinal(13)] 
		[RED("mouseRotationSpeed")] 
		public CFloat MouseRotationSpeed
		{
			get => GetProperty(ref _mouseRotationSpeed);
			set => SetProperty(ref _mouseRotationSpeed, value);
		}

		public gameuiInventoryPuppetPreviewGameController()
		{
			_maxMousePointerOffset = 40.000000F;
			_mouseRotationSpeed = 250.000000F;
		}
	}
}

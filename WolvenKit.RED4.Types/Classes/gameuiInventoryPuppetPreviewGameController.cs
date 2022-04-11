using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiInventoryPuppetPreviewGameController : gameuiPuppetPreviewGameController
	{
		[Ordinal(8)] 
		[RED("sceneName")] 
		public CName SceneName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("cameraRef")] 
		public NodeRef CameraRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(10)] 
		[RED("collider")] 
		public inkWidgetReference Collider
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("rotationIsMouseDown")] 
		public CBool RotationIsMouseDown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("maxMousePointerOffset")] 
		public CFloat MaxMousePointerOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("mouseRotationSpeed")] 
		public CFloat MouseRotationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiInventoryPuppetPreviewGameController()
		{
			RotationSpeed = 60.000000F;
			Collider = new();
			MaxMousePointerOffset = 40.000000F;
			MouseRotationSpeed = 250.000000F;
		}
	}
}

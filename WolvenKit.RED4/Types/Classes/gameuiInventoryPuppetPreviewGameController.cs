using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiInventoryPuppetPreviewGameController : gameuiPuppetPreviewGameController
	{
		[Ordinal(9)] 
		[RED("sceneName")] 
		public CName SceneName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("cameraRef")] 
		public NodeRef CameraRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(11)] 
		[RED("collider")] 
		public inkWidgetReference Collider
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("rotationIsMouseDown")] 
		public CBool RotationIsMouseDown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("maxMousePointerOffset")] 
		public CFloat MaxMousePointerOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("mouseRotationSpeed")] 
		public CFloat MouseRotationSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiInventoryPuppetPreviewGameController()
		{
			RotationSpeed = 60.000000F;
			Collider = new inkWidgetReference();
			MaxMousePointerOffset = 40.000000F;
			MouseRotationSpeed = 250.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

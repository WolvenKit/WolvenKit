using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiItemPreviewGameController : gameuiPreviewGameController
	{
		[Ordinal(7)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

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

		public gameuiItemPreviewGameController()
		{
			YawSpeed = 1.250000F;
			YawDefault = -125.000000F;
			RotationSpeed = 30.000000F;
			Image = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

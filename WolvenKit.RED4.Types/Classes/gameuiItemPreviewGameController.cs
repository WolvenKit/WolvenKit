using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiItemPreviewGameController : gameuiPreviewGameController
	{
		[Ordinal(7)] 
		[RED("sceneName")] 
		public CName SceneName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
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
		}
	}
}

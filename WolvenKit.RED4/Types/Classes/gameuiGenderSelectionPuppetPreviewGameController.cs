using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiGenderSelectionPuppetPreviewGameController : gameuiPuppetPreviewGameController
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

		public gameuiGenderSelectionPuppetPreviewGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

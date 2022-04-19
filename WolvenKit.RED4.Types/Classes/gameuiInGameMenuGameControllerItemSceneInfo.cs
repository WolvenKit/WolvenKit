using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiInGameMenuGameControllerItemSceneInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("sceneName")] 
		public CName SceneName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("puppetSceneName")] 
		public CName PuppetSceneName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("prefabRef")] 
		public NodeRef PrefabRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(3)] 
		[RED("markerRef")] 
		public NodeRef MarkerRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public gameuiInGameMenuGameControllerItemSceneInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

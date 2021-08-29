using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiInGameMenuGameControllerItemSceneInfo : RedBaseClass
	{
		private CName _sceneName;
		private CName _puppetSceneName;
		private NodeRef _prefabRef;
		private NodeRef _markerRef;

		[Ordinal(0)] 
		[RED("sceneName")] 
		public CName SceneName
		{
			get => GetProperty(ref _sceneName);
			set => SetProperty(ref _sceneName, value);
		}

		[Ordinal(1)] 
		[RED("puppetSceneName")] 
		public CName PuppetSceneName
		{
			get => GetProperty(ref _puppetSceneName);
			set => SetProperty(ref _puppetSceneName, value);
		}

		[Ordinal(2)] 
		[RED("prefabRef")] 
		public NodeRef PrefabRef
		{
			get => GetProperty(ref _prefabRef);
			set => SetProperty(ref _prefabRef, value);
		}

		[Ordinal(3)] 
		[RED("markerRef")] 
		public NodeRef MarkerRef
		{
			get => GetProperty(ref _markerRef);
			set => SetProperty(ref _markerRef, value);
		}
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiInGameMenuGameControllerItemSceneInfo : CVariable
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

		public gameuiInGameMenuGameControllerItemSceneInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

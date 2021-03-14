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
			get
			{
				if (_sceneName == null)
				{
					_sceneName = (CName) CR2WTypeManager.Create("CName", "sceneName", cr2w, this);
				}
				return _sceneName;
			}
			set
			{
				if (_sceneName == value)
				{
					return;
				}
				_sceneName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("puppetSceneName")] 
		public CName PuppetSceneName
		{
			get
			{
				if (_puppetSceneName == null)
				{
					_puppetSceneName = (CName) CR2WTypeManager.Create("CName", "puppetSceneName", cr2w, this);
				}
				return _puppetSceneName;
			}
			set
			{
				if (_puppetSceneName == value)
				{
					return;
				}
				_puppetSceneName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("prefabRef")] 
		public NodeRef PrefabRef
		{
			get
			{
				if (_prefabRef == null)
				{
					_prefabRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "prefabRef", cr2w, this);
				}
				return _prefabRef;
			}
			set
			{
				if (_prefabRef == value)
				{
					return;
				}
				_prefabRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("markerRef")] 
		public NodeRef MarkerRef
		{
			get
			{
				if (_markerRef == null)
				{
					_markerRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "markerRef", cr2w, this);
				}
				return _markerRef;
			}
			set
			{
				if (_markerRef == value)
				{
					return;
				}
				_markerRef = value;
				PropertySet(this);
			}
		}

		public gameuiInGameMenuGameControllerItemSceneInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiInGameMenuGameControllerItemSceneInfo : CVariable
	{
		[Ordinal(0)] [RED("sceneName")] public CName SceneName { get; set; }
		[Ordinal(1)] [RED("puppetSceneName")] public CName PuppetSceneName { get; set; }
		[Ordinal(2)] [RED("prefabRef")] public NodeRef PrefabRef { get; set; }
		[Ordinal(3)] [RED("markerRef")] public NodeRef MarkerRef { get; set; }

		public gameuiInGameMenuGameControllerItemSceneInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

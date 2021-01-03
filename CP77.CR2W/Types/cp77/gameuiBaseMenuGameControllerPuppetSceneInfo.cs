using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiBaseMenuGameControllerPuppetSceneInfo : CVariable
	{
		[Ordinal(0)]  [RED("entityTemplate")] public raRef<entEntityTemplate> EntityTemplate { get; set; }
		[Ordinal(1)]  [RED("gender")] public CEnum<gameuiBaseMenuGameControllerPuppetGenderInfo> Gender { get; set; }
		[Ordinal(2)]  [RED("markerRef")] public NodeRef MarkerRef { get; set; }
		[Ordinal(3)]  [RED("prefabRef")] public NodeRef PrefabRef { get; set; }
		[Ordinal(4)]  [RED("puppetRecordId")] public TweakDBID PuppetRecordId { get; set; }
		[Ordinal(5)]  [RED("sceneName")] public CName SceneName { get; set; }

		public gameuiBaseMenuGameControllerPuppetSceneInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

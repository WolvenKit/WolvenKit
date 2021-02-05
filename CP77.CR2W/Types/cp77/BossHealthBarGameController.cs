using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BossHealthBarGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("healthControllerRef")] public inkWidgetReference HealthControllerRef { get; set; }
		[Ordinal(8)]  [RED("healthPersentage")] public inkTextWidgetReference HealthPersentage { get; set; }
		[Ordinal(9)]  [RED("bossName")] public inkTextWidgetReference BossName { get; set; }
		[Ordinal(10)]  [RED("statListener")] public CHandle<BossHealthStatListener> StatListener { get; set; }
		[Ordinal(11)]  [RED("boss")] public wCHandle<NPCPuppet> Boss { get; set; }
		[Ordinal(12)]  [RED("healthController")] public wCHandle<NameplateBarLogicController> HealthController { get; set; }
		[Ordinal(13)]  [RED("root")] public CHandle<inkWidget> Root { get; set; }
		[Ordinal(14)]  [RED("foldAnimation")] public CHandle<inkanimProxy> FoldAnimation { get; set; }
		[Ordinal(15)]  [RED("bossPuppets")] public CArray<wCHandle<NPCPuppet>> BossPuppets { get; set; }

		public BossHealthBarGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

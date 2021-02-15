using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BossHealthBarGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("healthControllerRef")] public inkWidgetReference HealthControllerRef { get; set; }
		[Ordinal(10)] [RED("healthPersentage")] public inkTextWidgetReference HealthPersentage { get; set; }
		[Ordinal(11)] [RED("bossName")] public inkTextWidgetReference BossName { get; set; }
		[Ordinal(12)] [RED("statListener")] public CHandle<BossHealthStatListener> StatListener { get; set; }
		[Ordinal(13)] [RED("boss")] public wCHandle<NPCPuppet> Boss { get; set; }
		[Ordinal(14)] [RED("healthController")] public wCHandle<NameplateBarLogicController> HealthController { get; set; }
		[Ordinal(15)] [RED("root")] public CHandle<inkWidget> Root { get; set; }
		[Ordinal(16)] [RED("foldAnimation")] public CHandle<inkanimProxy> FoldAnimation { get; set; }
		[Ordinal(17)] [RED("bossPuppets")] public CArray<wCHandle<NPCPuppet>> BossPuppets { get; set; }

		public BossHealthBarGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

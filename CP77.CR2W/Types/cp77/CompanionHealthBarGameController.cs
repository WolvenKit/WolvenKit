using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CompanionHealthBarGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("companionBlackboard")] public CHandle<gameIBlackboard> CompanionBlackboard { get; set; }
		[Ordinal(1)]  [RED("flatheadListener")] public CUInt32 FlatheadListener { get; set; }
		[Ordinal(2)]  [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }
		[Ordinal(3)]  [RED("healthStatListener")] public CHandle<CompanionHealthStatListener> HealthStatListener { get; set; }
		[Ordinal(4)]  [RED("healthbar")] public inkWidgetReference Healthbar { get; set; }
		[Ordinal(5)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(6)]  [RED("maxHealth")] public CFloat MaxHealth { get; set; }
		[Ordinal(7)]  [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(8)]  [RED("statSystem")] public CHandle<gameStatPoolsSystem> StatSystem { get; set; }

		public CompanionHealthBarGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

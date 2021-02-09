using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerPerkDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("WoundedInstigated")] public gamebbScriptID_Uint32 WoundedInstigated { get; set; }
		[Ordinal(1)]  [RED("DismembermentInstigated")] public gamebbScriptID_Uint32 DismembermentInstigated { get; set; }
		[Ordinal(2)]  [RED("EntityNoticedPlayer")] public gamebbScriptID_Uint32 EntityNoticedPlayer { get; set; }
		[Ordinal(3)]  [RED("CombatStateTime")] public gamebbScriptID_Float CombatStateTime { get; set; }

		public PlayerPerkDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

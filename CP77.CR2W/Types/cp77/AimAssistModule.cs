using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AimAssistModule : HUDModule
	{
		[Ordinal(0)]  [RED("hud")] public wCHandle<HUDManager> Hud { get; set; }
		[Ordinal(1)]  [RED("state")] public CEnum<ModuleState> State { get; set; }
		[Ordinal(2)]  [RED("instancesList")] public CArray<CHandle<ModuleInstance>> InstancesList { get; set; }
		[Ordinal(3)]  [RED("activeAssists")] public CArray<CHandle<AimAssist>> ActiveAssists { get; set; }

		public AimAssistModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

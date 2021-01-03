using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HUDModule : IScriptable
	{
		[Ordinal(0)]  [RED("hud")] public wCHandle<HUDManager> Hud { get; set; }
		[Ordinal(1)]  [RED("instancesList")] public CArray<CHandle<ModuleInstance>> InstancesList { get; set; }
		[Ordinal(2)]  [RED("state")] public CEnum<ModuleState> State { get; set; }

		public HUDModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

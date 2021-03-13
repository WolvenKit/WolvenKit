using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LocalPlayerDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("InsideVehicleForbiddenAreasCount")] public gamebbScriptID_Int32 InsideVehicleForbiddenAreasCount { get; set; }

		public LocalPlayerDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

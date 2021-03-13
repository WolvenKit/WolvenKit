using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VentilationAreaSetup : CVariable
	{
		[Ordinal(0)] [RED("areaEffect")] public CEnum<ETrapEffects> AreaEffect { get; set; }
		[Ordinal(1)] [RED("actionName")] public CName ActionName { get; set; }

		public VentilationAreaSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

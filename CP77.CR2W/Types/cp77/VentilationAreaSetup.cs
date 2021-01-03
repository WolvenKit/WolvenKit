using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VentilationAreaSetup : CVariable
	{
		[Ordinal(0)]  [RED("actionName")] public CName ActionName { get; set; }
		[Ordinal(1)]  [RED("areaEffect")] public CEnum<ETrapEffects> AreaEffect { get; set; }

		public VentilationAreaSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

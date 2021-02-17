using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CuttingGrenadePotentialTarget : CVariable
	{
		[Ordinal(0)] [RED("entity")] public wCHandle<ScriptedPuppet> Entity { get; set; }
		[Ordinal(1)] [RED("hits")] public CInt32 Hits { get; set; }

		public CuttingGrenadePotentialTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

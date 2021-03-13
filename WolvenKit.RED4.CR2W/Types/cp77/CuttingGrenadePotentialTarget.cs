using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CuttingGrenadePotentialTarget : CVariable
	{
		[Ordinal(0)] [RED("entity")] public wCHandle<ScriptedPuppet> Entity { get; set; }
		[Ordinal(1)] [RED("hits")] public CInt32 Hits { get; set; }

		public CuttingGrenadePotentialTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

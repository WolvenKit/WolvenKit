using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questdbgCallstackPhase : questdbgCallstackBlock
	{
		[Ordinal(2)] [RED("phases")] public CArray<CUInt64> Phases { get; set; }
		[Ordinal(3)] [RED("blocks")] public CArray<CUInt64> Blocks { get; set; }

		public questdbgCallstackPhase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

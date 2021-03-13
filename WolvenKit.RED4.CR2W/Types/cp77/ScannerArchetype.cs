using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerArchetype : ScannerChunk
	{
		[Ordinal(0)] [RED("archetype")] public CEnum<gamedataArchetypeType> Archetype { get; set; }

		public ScannerArchetype(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

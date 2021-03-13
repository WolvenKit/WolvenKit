using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAmbientPaletteExclusionAreaNode : worldAreaShapeNode
	{
		[Ordinal(6)] [RED("exclusionPaletteEntries")] public CArray<audioAmbientPaletteEntry> ExclusionPaletteEntries { get; set; }

		public worldAmbientPaletteExclusionAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

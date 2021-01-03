using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldAmbientPaletteExclusionAreaNode : worldAreaShapeNode
	{
		[Ordinal(0)]  [RED("exclusionPaletteEntries")] public CArray<audioAmbientPaletteEntry> ExclusionPaletteEntries { get; set; }

		public worldAmbientPaletteExclusionAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAmbientPaletteExclusionAreaNode : worldAreaShapeNode
	{
		private CArray<audioAmbientPaletteEntry> _exclusionPaletteEntries;

		[Ordinal(6)] 
		[RED("exclusionPaletteEntries")] 
		public CArray<audioAmbientPaletteEntry> ExclusionPaletteEntries
		{
			get => GetProperty(ref _exclusionPaletteEntries);
			set => SetProperty(ref _exclusionPaletteEntries, value);
		}

		public worldAmbientPaletteExclusionAreaNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

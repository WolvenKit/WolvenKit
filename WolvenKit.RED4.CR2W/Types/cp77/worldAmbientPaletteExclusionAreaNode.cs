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
			get
			{
				if (_exclusionPaletteEntries == null)
				{
					_exclusionPaletteEntries = (CArray<audioAmbientPaletteEntry>) CR2WTypeManager.Create("array:audioAmbientPaletteEntry", "exclusionPaletteEntries", cr2w, this);
				}
				return _exclusionPaletteEntries;
			}
			set
			{
				if (_exclusionPaletteEntries == value)
				{
					return;
				}
				_exclusionPaletteEntries = value;
				PropertySet(this);
			}
		}

		public worldAmbientPaletteExclusionAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

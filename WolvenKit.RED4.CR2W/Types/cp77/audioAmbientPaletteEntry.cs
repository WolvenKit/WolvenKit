using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAmbientPaletteEntry : CVariable
	{
		private CName _brushCategory;

		[Ordinal(0)] 
		[RED("brushCategory")] 
		public CName BrushCategory
		{
			get => GetProperty(ref _brushCategory);
			set => SetProperty(ref _brushCategory, value);
		}

		public audioAmbientPaletteEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

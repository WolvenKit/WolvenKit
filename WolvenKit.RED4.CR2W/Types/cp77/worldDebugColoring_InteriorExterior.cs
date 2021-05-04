using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_InteriorExterior : worldEditorDebugColoringSettings
	{
		private CColor _interiorColor;
		private CColor _openInteriorColor;
		private CColor _exteriorColor;

		[Ordinal(0)] 
		[RED("interiorColor")] 
		public CColor InteriorColor
		{
			get => GetProperty(ref _interiorColor);
			set => SetProperty(ref _interiorColor, value);
		}

		[Ordinal(1)] 
		[RED("openInteriorColor")] 
		public CColor OpenInteriorColor
		{
			get => GetProperty(ref _openInteriorColor);
			set => SetProperty(ref _openInteriorColor, value);
		}

		[Ordinal(2)] 
		[RED("exteriorColor")] 
		public CColor ExteriorColor
		{
			get => GetProperty(ref _exteriorColor);
			set => SetProperty(ref _exteriorColor, value);
		}

		public worldDebugColoring_InteriorExterior(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

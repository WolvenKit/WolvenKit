using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_GIDebug : worldEditorDebugColoringSettings
	{
		private CColor _gIVisibleColor;
		private CColor _gITransparentColor;

		[Ordinal(0)] 
		[RED("GIVisibleColor")] 
		public CColor GIVisibleColor
		{
			get => GetProperty(ref _gIVisibleColor);
			set => SetProperty(ref _gIVisibleColor, value);
		}

		[Ordinal(1)] 
		[RED("GITransparentColor")] 
		public CColor GITransparentColor
		{
			get => GetProperty(ref _gITransparentColor);
			set => SetProperty(ref _gITransparentColor, value);
		}

		public worldDebugColoring_GIDebug(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

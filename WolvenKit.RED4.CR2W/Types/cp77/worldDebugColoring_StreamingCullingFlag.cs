using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_StreamingCullingFlag : worldEditorDebugColoringSettings
	{
		private CColor _cullableColor;
		private CColor _forceCulledAlwaysColor;
		private CColor _forceCulledPeripheralColor;
		private CColor _defaultColor;

		[Ordinal(0)] 
		[RED("cullableColor")] 
		public CColor CullableColor
		{
			get => GetProperty(ref _cullableColor);
			set => SetProperty(ref _cullableColor, value);
		}

		[Ordinal(1)] 
		[RED("forceCulledAlwaysColor")] 
		public CColor ForceCulledAlwaysColor
		{
			get => GetProperty(ref _forceCulledAlwaysColor);
			set => SetProperty(ref _forceCulledAlwaysColor, value);
		}

		[Ordinal(2)] 
		[RED("forceCulledPeripheralColor")] 
		public CColor ForceCulledPeripheralColor
		{
			get => GetProperty(ref _forceCulledPeripheralColor);
			set => SetProperty(ref _forceCulledPeripheralColor, value);
		}

		[Ordinal(3)] 
		[RED("defaultColor")] 
		public CColor DefaultColor
		{
			get => GetProperty(ref _defaultColor);
			set => SetProperty(ref _defaultColor, value);
		}

		public worldDebugColoring_StreamingCullingFlag(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

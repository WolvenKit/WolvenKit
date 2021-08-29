using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDebugColoring_StreamingCullingFlag : worldEditorDebugColoringSettings
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
	}
}

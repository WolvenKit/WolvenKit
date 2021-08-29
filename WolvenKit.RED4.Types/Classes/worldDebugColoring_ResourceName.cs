using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDebugColoring_ResourceName : worldEditorDebugColoringSettings
	{
		private CArray<worldNameColorPair> _names;
		private CColor _defaultColor;

		[Ordinal(0)] 
		[RED("names")] 
		public CArray<worldNameColorPair> Names
		{
			get => GetProperty(ref _names);
			set => SetProperty(ref _names, value);
		}

		[Ordinal(1)] 
		[RED("defaultColor")] 
		public CColor DefaultColor
		{
			get => GetProperty(ref _defaultColor);
			set => SetProperty(ref _defaultColor, value);
		}
	}
}

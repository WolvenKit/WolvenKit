using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDebugColoring_ResourceName : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] 
		[RED("names")] 
		public CArray<worldNameColorPair> Names
		{
			get => GetPropertyValue<CArray<worldNameColorPair>>();
			set => SetPropertyValue<CArray<worldNameColorPair>>(value);
		}

		[Ordinal(1)] 
		[RED("defaultColor")] 
		public CColor DefaultColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public worldDebugColoring_ResourceName()
		{
			Names = new();
			DefaultColor = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

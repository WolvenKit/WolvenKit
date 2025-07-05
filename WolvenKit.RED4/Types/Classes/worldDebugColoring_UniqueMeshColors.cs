using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDebugColoring_UniqueMeshColors : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] 
		[RED("alpha")] 
		public CUInt8 Alpha
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public worldDebugColoring_UniqueMeshColors()
		{
			Alpha = 192;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

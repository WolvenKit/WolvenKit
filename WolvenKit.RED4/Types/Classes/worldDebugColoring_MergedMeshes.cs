using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDebugColoring_MergedMeshes : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] 
		[RED("defaultColor")] 
		public CColor DefaultColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(1)] 
		[RED("mergedMeshColor")] 
		public CColor MergedMeshColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public worldDebugColoring_MergedMeshes()
		{
			DefaultColor = new CColor { Red = 255, Green = 255, Blue = 255, Alpha = 255 };
			MergedMeshColor = new CColor { Red = 255, Alpha = 255 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

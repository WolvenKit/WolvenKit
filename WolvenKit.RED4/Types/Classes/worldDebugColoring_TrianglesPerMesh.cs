using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldDebugColoring_TrianglesPerMesh : worldEditorDebugColoringSettings
	{
		[Ordinal(0)] 
		[RED("maxColor")] 
		public CColor MaxColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(1)] 
		[RED("minColor")] 
		public CColor MinColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(2)] 
		[RED("minCount")] 
		public CUInt32 MinCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("maxCount")] 
		public CUInt32 MaxCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public worldDebugColoring_TrianglesPerMesh()
		{
			MaxColor = new CColor();
			MinColor = new CColor();
			MinCount = 500;
			MaxCount = 20000;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

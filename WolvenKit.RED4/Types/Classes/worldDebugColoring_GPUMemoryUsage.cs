
namespace WolvenKit.RED4.Types
{
	public partial class worldDebugColoring_GPUMemoryUsage : worldDebugColoring_MetricsUsageAbstractBase
	{
		public worldDebugColoring_GPUMemoryUsage()
		{
			MaxColor = new CColor { Red = 255, Alpha = 255 };
			MinColor = new CColor { Green = 255, Alpha = 255 };
			MinSize = 1;
			MaxSize = 5000;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

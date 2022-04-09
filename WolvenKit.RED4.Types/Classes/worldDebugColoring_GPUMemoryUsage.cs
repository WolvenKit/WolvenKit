
namespace WolvenKit.RED4.Types
{
	public partial class worldDebugColoring_GPUMemoryUsage : worldDebugColoring_MetricsUsageAbstractBase
	{
		public worldDebugColoring_GPUMemoryUsage()
		{
			MaxColor = new();
			MinColor = new();
			MinSize = 1;
			MaxSize = 5000;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

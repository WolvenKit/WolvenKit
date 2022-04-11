
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDebugColoring_GPUMemoryUsage : worldDebugColoring_MetricsUsageAbstractBase
	{

		public worldDebugColoring_GPUMemoryUsage()
		{
			MaxColor = new();
			MinColor = new();
			MinSize = 1;
			MaxSize = 5000;
		}
	}
}

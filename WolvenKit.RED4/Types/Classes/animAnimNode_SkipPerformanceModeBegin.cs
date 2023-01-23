
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SkipPerformanceModeBegin : animAnimNode_OnePoseInput
	{
		public animAnimNode_SkipPerformanceModeBegin()
		{
			Id = 4294967295;
			InputLink = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

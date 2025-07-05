
namespace WolvenKit.RED4.Types
{
	public partial class SampleComponentWithCounter : gameScriptableComponent
	{
		public SampleComponentWithCounter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

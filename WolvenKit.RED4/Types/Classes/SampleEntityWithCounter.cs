
namespace WolvenKit.RED4.Types
{
	public partial class SampleEntityWithCounter : gameObject
	{
		public SampleEntityWithCounter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}


namespace WolvenKit.RED4.Types
{
	public partial class DelaySpawning : redEvent
	{
		public DelaySpawning()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

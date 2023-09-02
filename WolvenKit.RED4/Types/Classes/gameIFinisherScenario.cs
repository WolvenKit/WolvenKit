
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIFinisherScenario : ISerializable
	{
		public gameIFinisherScenario()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

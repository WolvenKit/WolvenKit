
namespace WolvenKit.RED4.Types
{
	public abstract partial class scnsimIActionScenario : ISerializable
	{
		public scnsimIActionScenario()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

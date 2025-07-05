
namespace WolvenKit.RED4.Types
{
	public abstract partial class populationModifier : ISerializable
	{
		public populationModifier()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

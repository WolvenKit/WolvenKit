
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameinteractionsIFunctorDefinition : ISerializable
	{
		public gameinteractionsIFunctorDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

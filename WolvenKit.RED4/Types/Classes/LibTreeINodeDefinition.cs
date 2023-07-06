
namespace WolvenKit.RED4.Types
{
	public abstract partial class LibTreeINodeDefinition : ISerializable
	{
		public LibTreeINodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

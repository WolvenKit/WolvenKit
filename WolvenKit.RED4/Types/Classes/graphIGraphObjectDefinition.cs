
namespace WolvenKit.RED4.Types
{
	public abstract partial class graphIGraphObjectDefinition : ISerializable
	{
		public graphIGraphObjectDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

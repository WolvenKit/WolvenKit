
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameSignalUserDataDefinition : ISerializable
	{
		public gameSignalUserDataDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

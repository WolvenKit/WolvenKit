
namespace WolvenKit.RED4.Types
{
	public abstract partial class gamestateMachineIStateActionDefinition : ISerializable
	{
		public gamestateMachineIStateActionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}


namespace WolvenKit.RED4.Types
{
	public partial class AISquadBase : ISerializable
	{
		public AISquadBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

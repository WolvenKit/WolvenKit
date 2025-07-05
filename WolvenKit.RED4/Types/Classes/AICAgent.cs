
namespace WolvenKit.RED4.Types
{
	public partial class AICAgent : gameComponent
	{
		public AICAgent()
		{
			Name = "AIComponent";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

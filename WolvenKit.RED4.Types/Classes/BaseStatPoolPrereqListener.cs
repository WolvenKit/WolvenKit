
namespace WolvenKit.RED4.Types
{
	public partial class BaseStatPoolPrereqListener : gameCustomValueStatPoolsListener
	{
		public BaseStatPoolPrereqListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

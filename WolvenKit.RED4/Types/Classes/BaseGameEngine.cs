
namespace WolvenKit.RED4.Types
{
	public partial class BaseGameEngine : CBaseEngine
	{
		public BaseGameEngine()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

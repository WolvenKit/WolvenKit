
namespace WolvenKit.RED4.Types
{
	public partial class HeadlessGameEngine : BaseGameEngine
	{
		public HeadlessGameEngine()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}


namespace WolvenKit.RED4.Types
{
	public partial class LateInit : redEvent
	{
		public LateInit()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

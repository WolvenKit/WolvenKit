
namespace WolvenKit.RED4.Types
{
	public partial class CleanPasswordEvent : redEvent
	{
		public CleanPasswordEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}


namespace WolvenKit.RED4.Types
{
	public partial class NextFrameEvent : redEvent
	{
		public NextFrameEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

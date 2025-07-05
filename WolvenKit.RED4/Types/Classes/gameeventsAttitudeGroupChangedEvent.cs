
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameeventsAttitudeGroupChangedEvent : redEvent
	{
		public gameeventsAttitudeGroupChangedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

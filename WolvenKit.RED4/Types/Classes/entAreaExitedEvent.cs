
namespace WolvenKit.RED4.Types
{
	public partial class entAreaExitedEvent : entTriggerEvent
	{
		public entAreaExitedEvent()
		{
			TriggerID = new entEntityID();
			Activator = new entEntityGameInterface();
			WorldPosition = new Vector4 { W = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

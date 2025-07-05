
namespace WolvenKit.RED4.Types
{
	public partial class entAreaEnteredEvent : entTriggerEvent
	{
		public entAreaEnteredEvent()
		{
			TriggerID = new entEntityID();
			Activator = new entEntityGameInterface();
			WorldPosition = new Vector4 { W = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

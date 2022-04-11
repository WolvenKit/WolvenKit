
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAreaEnteredEvent : entTriggerEvent
	{

		public entAreaEnteredEvent()
		{
			TriggerID = new();
			Activator = new();
			WorldPosition = new() { W = 1.000000F };
		}
	}
}

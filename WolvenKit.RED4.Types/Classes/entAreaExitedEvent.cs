
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAreaExitedEvent : entTriggerEvent
	{

		public entAreaExitedEvent()
		{
			TriggerID = new();
			Activator = new();
			WorldPosition = new() { W = 1.000000F };
		}
	}
}

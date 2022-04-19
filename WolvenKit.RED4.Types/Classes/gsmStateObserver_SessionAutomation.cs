
namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	public partial class gsmStateObserver_SessionAutomation : gsmIStateObserver
	{
		public gsmStateObserver_SessionAutomation()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

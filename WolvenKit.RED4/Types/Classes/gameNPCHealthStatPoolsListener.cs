
namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	public partial class gameNPCHealthStatPoolsListener : gamePuppetStatPoolsListener
	{
		public gameNPCHealthStatPoolsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

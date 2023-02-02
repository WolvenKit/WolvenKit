
namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	public partial class gamePlayerHealthStatPoolsListener : gamePuppetStatPoolsListener
	{
		public gamePlayerHealthStatPoolsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}


namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	public partial class gamePlayerArmorStatPoolsListener : gamePuppetStatPoolsListener
	{
		public gamePlayerArmorStatPoolsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

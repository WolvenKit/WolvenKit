
namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	public partial class gameNPCQuickHackUploadStatPoolsListener : gamePuppetStatPoolsListener
	{
		public gameNPCQuickHackUploadStatPoolsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

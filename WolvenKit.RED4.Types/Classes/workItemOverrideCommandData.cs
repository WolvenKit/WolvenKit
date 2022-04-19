
namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	public partial class workItemOverrideCommandData : workIWorkspotCommandData
	{
		public workItemOverrideCommandData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

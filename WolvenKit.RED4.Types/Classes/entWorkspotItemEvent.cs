
namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	public partial class entWorkspotItemEvent : redEvent
	{
		public entWorkspotItemEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

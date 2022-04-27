
namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	public partial class workEquipItemCommandData : workIWorkspotCommandData
	{
		public workEquipItemCommandData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}


namespace WolvenKit.RED4.Types
{
	public partial class workSyncMasterEntryAnim : workEntryAnim
	{
		public workSyncMasterEntryAnim()
		{
			IsSynchronized = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}


namespace WolvenKit.RED4.Types
{
	public abstract partial class questHolocallStateListener : worldIQuestPrefabStateListener
	{
		public questHolocallStateListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

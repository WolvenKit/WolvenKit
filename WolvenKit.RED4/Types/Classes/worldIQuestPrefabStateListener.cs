
namespace WolvenKit.RED4.Types
{
	public abstract partial class worldIQuestPrefabStateListener : ISerializable
	{
		public worldIQuestPrefabStateListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

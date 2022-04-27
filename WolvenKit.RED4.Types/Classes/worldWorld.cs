
namespace WolvenKit.RED4.Types
{
	public partial class worldWorld : worldPrefab
	{
		public worldWorld()
		{
			Type = Enums.worldPrefabType.Area;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

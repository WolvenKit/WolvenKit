
namespace WolvenKit.RED4.Types
{
	public partial class gameEntityStubComponentPlacedProxy : entIPlacedComponent
	{
		public gameEntityStubComponentPlacedProxy()
		{
			Name = "entityStubPlacedProxy";
			LocalTransform = new WorldTransform();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

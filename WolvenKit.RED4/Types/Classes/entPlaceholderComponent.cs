
namespace WolvenKit.RED4.Types
{
	public partial class entPlaceholderComponent : entIPlacedComponent
	{
		public entPlaceholderComponent()
		{
			Name = "entPlaceholderComponent";
			LocalTransform = new WorldTransform();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

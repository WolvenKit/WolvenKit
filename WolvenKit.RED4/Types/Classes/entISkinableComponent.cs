
namespace WolvenKit.RED4.Types
{
	public abstract partial class entISkinableComponent : entIPlacedComponent
	{
		public entISkinableComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

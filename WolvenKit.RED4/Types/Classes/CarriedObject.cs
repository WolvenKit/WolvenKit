
namespace WolvenKit.RED4.Types
{
	public abstract partial class CarriedObject : OldUpperBodyTransition
	{
		public CarriedObject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

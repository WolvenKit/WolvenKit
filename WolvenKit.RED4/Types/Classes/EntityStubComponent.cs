
namespace WolvenKit.RED4.Types
{
	public abstract partial class EntityStubComponent : gameComponent
	{
		public EntityStubComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

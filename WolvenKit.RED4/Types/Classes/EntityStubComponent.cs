
namespace WolvenKit.RED4.Types
{
	public abstract partial class EntityStubComponent : gameComponent
	{
		public EntityStubComponent()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

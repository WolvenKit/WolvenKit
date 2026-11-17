
namespace WolvenKit.RED4.Types
{
	public partial class cpConveyorComponent : entIVisualComponent
	{
		public cpConveyorComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform();
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			ForceLODLevel = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

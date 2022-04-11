
namespace WolvenKit.RED4.Types
{
	public partial class cpConveyorComponent : entIVisualComponent
	{
		public cpConveyorComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			ForceLODLevel = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

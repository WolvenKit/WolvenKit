using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entVirtualCameraViewComponent : entIVisualComponent
	{
		[Ordinal(8)] 
		[RED("virtualCameraName")] 
		public CName VirtualCameraName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("targetPlaneSize")] 
		public Vector2 TargetPlaneSize
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public entVirtualCameraViewComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			ForceLODLevel = -1;
			VirtualCameraName = "Component";
			TargetPlaneSize = new() { X = 2.000000F, Y = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entVectorFieldComponent : entIVisualComponent
	{
		[Ordinal(8)] 
		[RED("direction")] 
		public Vector3 Direction
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(9)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public entVectorFieldComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform();
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			ForceLODLevel = -1;
			Direction = new Vector3();
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

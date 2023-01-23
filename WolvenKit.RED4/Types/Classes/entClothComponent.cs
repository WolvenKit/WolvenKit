using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entClothComponent : entIVisualComponent
	{
		[Ordinal(8)] 
		[RED("mesh")] 
		public CResourceReference<CMesh> Mesh
		{
			get => GetPropertyValue<CResourceReference<CMesh>>();
			set => SetPropertyValue<CResourceReference<CMesh>>(value);
		}

		[Ordinal(9)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public entClothComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			ForceLODLevel = -1;
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

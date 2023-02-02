using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entEffectSpawnerComponent : entIVisualComponent
	{
		[Ordinal(8)] 
		[RED("effectDescs")] 
		public CArray<CHandle<entEffectDesc>> EffectDescs
		{
			get => GetPropertyValue<CArray<CHandle<entEffectDesc>>>();
			set => SetPropertyValue<CArray<CHandle<entEffectDesc>>>(value);
		}

		public entEffectSpawnerComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			ForceLODLevel = -1;
			EffectDescs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

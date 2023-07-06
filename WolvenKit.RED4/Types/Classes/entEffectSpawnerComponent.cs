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
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			ForceLODLevel = -1;
			EffectDescs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

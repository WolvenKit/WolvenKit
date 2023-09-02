using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entFogVolumeComponent : entIVisualComponent
	{
		[Ordinal(8)] 
		[RED("densityFalloff")] 
		public CFloat DensityFalloff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("blendFalloff")] 
		public CFloat BlendFalloff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("densityFactor")] 
		public CFloat DensityFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(12)] 
		[RED("absorption")] 
		public CFloat Absorption
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("size")] 
		public Vector3 Size
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(14)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public entFogVolumeComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			ForceLODLevel = -1;
			DensityFactor = 100.000000F;
			Color = new CColor();
			Absorption = -1.000000F;
			Size = new Vector3 { X = 1.000000F, Y = 1.000000F, Z = 1.000000F };
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

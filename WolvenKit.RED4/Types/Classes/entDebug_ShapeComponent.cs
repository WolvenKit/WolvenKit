using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entDebug_ShapeComponent : entIVisualComponent
	{
		[Ordinal(8)] 
		[RED("shape")] 
		public CEnum<entDebug_ShapeType> Shape
		{
			get => GetPropertyValue<CEnum<entDebug_ShapeType>>();
			set => SetPropertyValue<CEnum<entDebug_ShapeType>>(value);
		}

		[Ordinal(9)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("halfHeight")] 
		public CFloat HalfHeight
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
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public entDebug_ShapeComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			RenderSceneLayerMask = Enums.RenderSceneLayerMask.Default;
			ForceLODLevel = -1;
			Radius = 0.500000F;
			HalfHeight = 0.500000F;
			Color = new CColor();
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

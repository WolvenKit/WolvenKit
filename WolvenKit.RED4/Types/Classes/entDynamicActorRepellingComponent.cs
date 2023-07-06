using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entDynamicActorRepellingComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("type")] 
		public CEnum<entRepellingType> Type
		{
			get => GetPropertyValue<CEnum<entRepellingType>>();
			set => SetPropertyValue<CEnum<entRepellingType>>(value);
		}

		[Ordinal(6)] 
		[RED("shape")] 
		public CEnum<entRepellingShape> Shape
		{
			get => GetPropertyValue<CEnum<entRepellingShape>>();
			set => SetPropertyValue<CEnum<entRepellingShape>>(value);
		}

		[Ordinal(7)] 
		[RED("magnitude")] 
		public CFloat Magnitude
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("bendIntensity")] 
		public CFloat BendIntensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("anchorPointVert")] 
		public CEnum<rendWindShapeAnchorPointVert> AnchorPointVert
		{
			get => GetPropertyValue<CEnum<rendWindShapeAnchorPointVert>>();
			set => SetPropertyValue<CEnum<rendWindShapeAnchorPointVert>>(value);
		}

		[Ordinal(10)] 
		[RED("anchorPointHorz")] 
		public CEnum<rendWindShapeAnchorPointHorz> AnchorPointHorz
		{
			get => GetPropertyValue<CEnum<rendWindShapeAnchorPointHorz>>();
			set => SetPropertyValue<CEnum<rendWindShapeAnchorPointHorz>>(value);
		}

		[Ordinal(11)] 
		[RED("anchorPointDepth")] 
		public CEnum<rendWindShapeAnchorPointDepth> AnchorPointDepth
		{
			get => GetPropertyValue<CEnum<rendWindShapeAnchorPointDepth>>();
			set => SetPropertyValue<CEnum<rendWindShapeAnchorPointDepth>>(value);
		}

		[Ordinal(12)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("capsuleRadius")] 
		public CFloat CapsuleRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("capsuleHeight")] 
		public CFloat CapsuleHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public entDynamicActorRepellingComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			Magnitude = 5.000000F;
			BendIntensity = 1.000000F;
			Radius = 1.000000F;
			CapsuleRadius = 1.000000F;
			CapsuleHeight = 2.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

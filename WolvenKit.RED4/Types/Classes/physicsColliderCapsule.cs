using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsColliderCapsule : physicsICollider
	{
		[Ordinal(8)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public physicsColliderCapsule()
		{
			LocalToBody = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } };
			MaterialApperanceOverrides = new();
			VolumeModifier = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

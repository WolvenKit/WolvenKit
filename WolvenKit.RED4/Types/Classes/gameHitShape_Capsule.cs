using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameHitShape_Capsule : gameHitShapeBase
	{
		[Ordinal(3)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameHitShape_Capsule()
		{
			Translation = new Vector3();
			Rotation = new Quaternion { R = 1.000000F };
			LocalTransform = new CMatrix();
			Radius = 0.200000F;
			Height = 0.400000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

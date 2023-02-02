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
			Translation = new();
			Rotation = new() { R = 1.000000F };
			LocalTransform = new();
			Radius = 0.200000F;
			Height = 0.400000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

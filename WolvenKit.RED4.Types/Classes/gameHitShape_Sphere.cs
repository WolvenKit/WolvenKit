using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameHitShape_Sphere : gameHitShapeBase
	{
		[Ordinal(3)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameHitShape_Sphere()
		{
			Translation = new();
			Rotation = new() { R = 1.000000F };
			LocalTransform = new();
			Radius = 0.200000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

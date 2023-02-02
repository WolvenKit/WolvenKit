using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkUITransform : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("translation")] 
		public Vector2 Translation
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(1)] 
		[RED("scale")] 
		public Vector2 Scale
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(2)] 
		[RED("shear")] 
		public Vector2 Shear
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(3)] 
		[RED("rotation")] 
		public CFloat Rotation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public inkUITransform()
		{
			Translation = new();
			Scale = new() { X = 1.000000F, Y = 1.000000F };
			Shear = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

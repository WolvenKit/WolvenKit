using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkDrawArea : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("size")] 
		public Vector2 Size
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(1)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("relativePosition")] 
		public Vector2 RelativePosition
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(3)] 
		[RED("absolutePosition")] 
		public Vector2 AbsolutePosition
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public inkDrawArea()
		{
			Size = new();
			Scale = 1.000000F;
			RelativePosition = new();
			AbsolutePosition = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

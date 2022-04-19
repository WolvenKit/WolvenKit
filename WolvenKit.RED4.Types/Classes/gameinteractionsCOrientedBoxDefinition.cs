using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsCOrientedBoxDefinition : gameinteractionsIShapeDefinition
	{
		[Ordinal(0)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("forward")] 
		public Vector4 Forward
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("right")] 
		public Vector4 Right
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(3)] 
		[RED("up")] 
		public Vector4 Up
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public gameinteractionsCOrientedBoxDefinition()
		{
			Position = new() { W = 1.000000F };
			Forward = new() { Y = 1.000000F };
			Right = new() { X = 1.000000F };
			Up = new() { Z = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

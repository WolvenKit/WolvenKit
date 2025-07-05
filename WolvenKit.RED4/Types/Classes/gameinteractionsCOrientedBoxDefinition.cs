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
			Position = new Vector4 { W = 1.000000F };
			Forward = new Vector4 { Y = 1.000000F };
			Right = new Vector4 { X = 1.000000F };
			Up = new Vector4 { Z = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

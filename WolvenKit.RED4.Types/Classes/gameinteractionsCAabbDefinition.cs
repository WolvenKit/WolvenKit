using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsCAabbDefinition : gameinteractionsIShapeDefinition
	{
		[Ordinal(0)] 
		[RED("min")] 
		public Vector4 Min
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("max")] 
		public Vector4 Max
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public gameinteractionsCAabbDefinition()
		{
			Min = new() { W = 1.000000F };
			Max = new() { W = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameQueryResult : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("hitShapes")] 
		public CArray<gameShapeData> HitShapes
		{
			get => GetPropertyValue<CArray<gameShapeData>>();
			set => SetPropertyValue<CArray<gameShapeData>>(value);
		}

		public gameQueryResult()
		{
			HitShapes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

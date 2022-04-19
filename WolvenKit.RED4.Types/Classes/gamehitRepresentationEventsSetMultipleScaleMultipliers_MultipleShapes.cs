using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamehitRepresentationEventsSetMultipleScaleMultipliers_MultipleShapes : redEvent
	{
		[Ordinal(0)] 
		[RED("scaleMultipliers")] 
		public CArray<Vector4> ScaleMultipliers
		{
			get => GetPropertyValue<CArray<Vector4>>();
			set => SetPropertyValue<CArray<Vector4>>(value);
		}

		[Ordinal(1)] 
		[RED("shapeNames")] 
		public CArray<CName> ShapeNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public gamehitRepresentationEventsSetMultipleScaleMultipliers_MultipleShapes()
		{
			ScaleMultipliers = new();
			ShapeNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

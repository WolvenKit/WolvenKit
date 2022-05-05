using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamehitRepresentationEventsSetSingleScaleMultiplier_MultipleShapes : gamehitRepresentationEventsSetSingleScaleMultiplier_AllShapes
	{
		[Ordinal(1)] 
		[RED("shapeNames")] 
		public CArray<CName> ShapeNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public gamehitRepresentationEventsSetSingleScaleMultiplier_MultipleShapes()
		{
			ShapeNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

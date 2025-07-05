using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsCHotSpotAreaFilterDefinition : gameinteractionsNodeDefinition
	{
		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("transform")] 
		public Transform Transform
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(2)] 
		[RED("functor")] 
		public CHandle<gameinteractionsCFunctorDefinition> Functor
		{
			get => GetPropertyValue<CHandle<gameinteractionsCFunctorDefinition>>();
			set => SetPropertyValue<CHandle<gameinteractionsCFunctorDefinition>>(value);
		}

		[Ordinal(3)] 
		[RED("shapes")] 
		public CArray<CHandle<gameinteractionsIShapeDefinition>> Shapes
		{
			get => GetPropertyValue<CArray<CHandle<gameinteractionsIShapeDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<gameinteractionsIShapeDefinition>>>(value);
		}

		[Ordinal(4)] 
		[RED("negativeShapes")] 
		public CArray<CHandle<gameinteractionsIShapeDefinition>> NegativeShapes
		{
			get => GetPropertyValue<CArray<CHandle<gameinteractionsIShapeDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<gameinteractionsIShapeDefinition>>>(value);
		}

		public gameinteractionsCHotSpotAreaFilterDefinition()
		{
			Transform = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } };
			Shapes = new();
			NegativeShapes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

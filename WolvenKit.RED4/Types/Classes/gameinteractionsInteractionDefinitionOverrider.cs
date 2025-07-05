using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsInteractionDefinitionOverrider : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("shapes")] 
		public CArray<CHandle<gameinteractionsIShapeDefinition>> Shapes
		{
			get => GetPropertyValue<CArray<CHandle<gameinteractionsIShapeDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<gameinteractionsIShapeDefinition>>>(value);
		}

		[Ordinal(2)] 
		[RED("negativeShapes")] 
		public CArray<CHandle<gameinteractionsIShapeDefinition>> NegativeShapes
		{
			get => GetPropertyValue<CArray<CHandle<gameinteractionsIShapeDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<gameinteractionsIShapeDefinition>>>(value);
		}

		[Ordinal(3)] 
		[RED("priorityMultiplier")] 
		public CFloat PriorityMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameinteractionsInteractionDefinitionOverrider()
		{
			Shapes = new();
			NegativeShapes = new();
			PriorityMultiplier = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

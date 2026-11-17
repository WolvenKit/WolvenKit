using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsInteractionDescriptorResource : CResource
	{
		[Ordinal(1)] 
		[RED("definition")] 
		public gameinteractionsCHotSpotDefinition Definition
		{
			get => GetPropertyValue<gameinteractionsCHotSpotDefinition>();
			set => SetPropertyValue<gameinteractionsCHotSpotDefinition>(value);
		}

		public gameinteractionsInteractionDescriptorResource()
		{
			Definition = new gameinteractionsCHotSpotDefinition { LayersDefinition = new() { new gameinteractionsCLinkedLayersDefinition { LayersDefinitions = new() { new gameinteractionsCHotSpotLayerDefinition { Enabled = true, Tag = "layer1", AreaFilterDefinition = new gameinteractionsCHotSpotAreaFilterDefinition { Functor = new gameinteractionsCFunctorDefinition { Predicate = new gameinteractionsCPredicateDefinition { PredicateType = new gameinteractionsContainedInShapesPredicate(), Functor1DataDefinition = new gameinteractionsCFunctorDefinition { Predicate = new gameinteractionsCPredicateDefinition { PredicateType = new gameinteractionsLookAtPredicate() } } } }, Shapes = new() { new gameinteractionsCSphereDefinition { Position = new Vector4(), Radius = 2.000000F } } }, GameLogicFilterDefinition = new gameinteractionsCHotSpotGameLogicFilterDefinition() } } } } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

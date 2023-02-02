using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExpressionTreeCGeneralCompositeNodeDefinition : ExpressionTreeCGeneralNodeDefinition
	{
		[Ordinal(0)] 
		[RED("children")] 
		public CArray<CHandle<LibTreeINodeDefinition>> Children
		{
			get => GetPropertyValue<CArray<CHandle<LibTreeINodeDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<LibTreeINodeDefinition>>>(value);
		}

		public ExpressionTreeCGeneralCompositeNodeDefinition()
		{
			Children = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

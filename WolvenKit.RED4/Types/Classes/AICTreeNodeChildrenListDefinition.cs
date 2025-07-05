using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AICTreeNodeChildrenListDefinition : AICTreeNodeCompositeDefinition
	{
		[Ordinal(0)] 
		[RED("children")] 
		public CArray<CHandle<LibTreeINodeDefinition>> Children
		{
			get => GetPropertyValue<CArray<CHandle<LibTreeINodeDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<LibTreeINodeDefinition>>>(value);
		}

		public AICTreeNodeChildrenListDefinition()
		{
			Children = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AICTreeNodeIncludedTreeDefinition : AICTreeNodeDefinition
	{
		[Ordinal(0)] 
		[RED("tree")] 
		public LibTreeDefTree Tree
		{
			get => GetPropertyValue<LibTreeDefTree>();
			set => SetPropertyValue<LibTreeDefTree>(value);
		}

		public AICTreeNodeIncludedTreeDefinition()
		{
			Tree = new LibTreeDefTree { VariableId = ushort.MaxValue };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeLazyNodeDefinition : AICTreeNodeDefinition
	{
		private CHandle<LibTreeCTreeResource> _tree;

		[Ordinal(0)] 
		[RED("tree")] 
		public CHandle<LibTreeCTreeResource> Tree
		{
			get => GetProperty(ref _tree);
			set => SetProperty(ref _tree, value);
		}
	}
}

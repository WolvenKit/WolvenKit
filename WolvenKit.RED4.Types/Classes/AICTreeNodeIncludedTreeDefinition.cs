using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeNodeIncludedTreeDefinition : AICTreeNodeDefinition
	{
		private LibTreeDefTree _tree;

		[Ordinal(0)] 
		[RED("tree")] 
		public LibTreeDefTree Tree
		{
			get => GetProperty(ref _tree);
			set => SetProperty(ref _tree, value);
		}
	}
}

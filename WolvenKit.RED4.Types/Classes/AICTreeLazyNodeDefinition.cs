using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICTreeLazyNodeDefinition : AICTreeNodeDefinition
	{
		[Ordinal(0)] 
		[RED("tree")] 
		public CHandle<LibTreeCTreeResource> Tree
		{
			get => GetPropertyValue<CHandle<LibTreeCTreeResource>>();
			set => SetPropertyValue<CHandle<LibTreeCTreeResource>>(value);
		}
	}
}

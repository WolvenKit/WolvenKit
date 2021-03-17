using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeLazyNodeDefinition : AICTreeNodeDefinition
	{
		private CHandle<LibTreeCTreeResource> _tree;

		[Ordinal(0)] 
		[RED("tree")] 
		public CHandle<LibTreeCTreeResource> Tree
		{
			get => GetProperty(ref _tree);
			set => SetProperty(ref _tree, value);
		}

		public AICTreeLazyNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

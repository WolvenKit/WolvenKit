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
			get
			{
				if (_tree == null)
				{
					_tree = (CHandle<LibTreeCTreeResource>) CR2WTypeManager.Create("handle:LibTreeCTreeResource", "tree", cr2w, this);
				}
				return _tree;
			}
			set
			{
				if (_tree == value)
				{
					return;
				}
				_tree = value;
				PropertySet(this);
			}
		}

		public AICTreeLazyNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

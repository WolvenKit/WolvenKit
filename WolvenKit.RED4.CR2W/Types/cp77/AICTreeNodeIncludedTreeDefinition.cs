using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeIncludedTreeDefinition : AICTreeNodeDefinition
	{
		private LibTreeDefTree _tree;

		[Ordinal(0)] 
		[RED("tree")] 
		public LibTreeDefTree Tree
		{
			get
			{
				if (_tree == null)
				{
					_tree = (LibTreeDefTree) CR2WTypeManager.Create("LibTreeDefTree", "tree", cr2w, this);
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

		public AICTreeNodeIncludedTreeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

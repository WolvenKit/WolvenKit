using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeDecoratorDefinition : AICTreeNodeDefinition
	{
		private CHandle<LibTreeINodeDefinition> _child;

		[Ordinal(0)] 
		[RED("child")] 
		public CHandle<LibTreeINodeDefinition> Child
		{
			get
			{
				if (_child == null)
				{
					_child = (CHandle<LibTreeINodeDefinition>) CR2WTypeManager.Create("handle:LibTreeINodeDefinition", "child", cr2w, this);
				}
				return _child;
			}
			set
			{
				if (_child == value)
				{
					return;
				}
				_child = value;
				PropertySet(this);
			}
		}

		public AICTreeNodeDecoratorDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

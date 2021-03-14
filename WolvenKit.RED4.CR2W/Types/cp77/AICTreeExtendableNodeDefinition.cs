using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeExtendableNodeDefinition : AICTreeNodeDefinition
	{
		private CHandle<LibTreeINodeDefinition> _optionalChild;

		[Ordinal(0)] 
		[RED("optionalChild")] 
		public CHandle<LibTreeINodeDefinition> OptionalChild
		{
			get
			{
				if (_optionalChild == null)
				{
					_optionalChild = (CHandle<LibTreeINodeDefinition>) CR2WTypeManager.Create("handle:LibTreeINodeDefinition", "optionalChild", cr2w, this);
				}
				return _optionalChild;
			}
			set
			{
				if (_optionalChild == value)
				{
					return;
				}
				_optionalChild = value;
				PropertySet(this);
			}
		}

		public AICTreeExtendableNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

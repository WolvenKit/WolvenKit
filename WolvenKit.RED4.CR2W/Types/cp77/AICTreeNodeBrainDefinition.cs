using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeBrainDefinition : AICTreeNodeCompositeDefinition
	{
		private CArray<CHandle<LibTreeINodeDefinition>> _children;
		private CBool _useScoring;

		[Ordinal(0)] 
		[RED("children")] 
		public CArray<CHandle<LibTreeINodeDefinition>> Children
		{
			get
			{
				if (_children == null)
				{
					_children = (CArray<CHandle<LibTreeINodeDefinition>>) CR2WTypeManager.Create("array:handle:LibTreeINodeDefinition", "children", cr2w, this);
				}
				return _children;
			}
			set
			{
				if (_children == value)
				{
					return;
				}
				_children = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("useScoring")] 
		public CBool UseScoring
		{
			get
			{
				if (_useScoring == null)
				{
					_useScoring = (CBool) CR2WTypeManager.Create("Bool", "useScoring", cr2w, this);
				}
				return _useScoring;
			}
			set
			{
				if (_useScoring == value)
				{
					return;
				}
				_useScoring = value;
				PropertySet(this);
			}
		}

		public AICTreeNodeBrainDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

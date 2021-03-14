using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorIncludedTreeDefinition : AIbehaviorNestedTreeDefinition
	{
		private CHandle<AIArgumentMapping> _treeReference;

		[Ordinal(2)] 
		[RED("treeReference")] 
		public CHandle<AIArgumentMapping> TreeReference
		{
			get
			{
				if (_treeReference == null)
				{
					_treeReference = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "treeReference", cr2w, this);
				}
				return _treeReference;
			}
			set
			{
				if (_treeReference == value)
				{
					return;
				}
				_treeReference = value;
				PropertySet(this);
			}
		}

		public AIbehaviorIncludedTreeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

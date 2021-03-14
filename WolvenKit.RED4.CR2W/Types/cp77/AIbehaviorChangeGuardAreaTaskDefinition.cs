using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorChangeGuardAreaTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _guardAreaNodeRef;

		[Ordinal(1)] 
		[RED("guardAreaNodeRef")] 
		public CHandle<AIArgumentMapping> GuardAreaNodeRef
		{
			get
			{
				if (_guardAreaNodeRef == null)
				{
					_guardAreaNodeRef = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "guardAreaNodeRef", cr2w, this);
				}
				return _guardAreaNodeRef;
			}
			set
			{
				if (_guardAreaNodeRef == value)
				{
					return;
				}
				_guardAreaNodeRef = value;
				PropertySet(this);
			}
		}

		public AIbehaviorChangeGuardAreaTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

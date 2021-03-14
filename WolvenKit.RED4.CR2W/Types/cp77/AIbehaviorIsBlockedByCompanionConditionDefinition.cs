using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorIsBlockedByCompanionConditionDefinition : AIbehaviorCompanionConditionDefinition
	{
		private CHandle<AIArgumentMapping> _distance;

		[Ordinal(3)] 
		[RED("distance")] 
		public CHandle<AIArgumentMapping> Distance
		{
			get
			{
				if (_distance == null)
				{
					_distance = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "distance", cr2w, this);
				}
				return _distance;
			}
			set
			{
				if (_distance == value)
				{
					return;
				}
				_distance = value;
				PropertySet(this);
			}
		}

		public AIbehaviorIsBlockedByCompanionConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

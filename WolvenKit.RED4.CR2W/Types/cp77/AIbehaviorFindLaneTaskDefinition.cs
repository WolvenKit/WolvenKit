using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorFindLaneTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _pointOnLane;
		private CEnum<worldFindLaneFilter> _filter;

		[Ordinal(1)] 
		[RED("pointOnLane")] 
		public CHandle<AIArgumentMapping> PointOnLane
		{
			get
			{
				if (_pointOnLane == null)
				{
					_pointOnLane = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "pointOnLane", cr2w, this);
				}
				return _pointOnLane;
			}
			set
			{
				if (_pointOnLane == value)
				{
					return;
				}
				_pointOnLane = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("filter")] 
		public CEnum<worldFindLaneFilter> Filter
		{
			get
			{
				if (_filter == null)
				{
					_filter = (CEnum<worldFindLaneFilter>) CR2WTypeManager.Create("worldFindLaneFilter", "filter", cr2w, this);
				}
				return _filter;
			}
			set
			{
				if (_filter == value)
				{
					return;
				}
				_filter = value;
				PropertySet(this);
			}
		}

		public AIbehaviorFindLaneTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldPatrolSplineNode : worldSplineNode
	{
		private CArray<CHandle<worldPatrolSplinePointDefinition>> _patrolPointDefs;
		private CArray<NodeRef> _patrolPoints;
		private CArray<CHandle<worldTrafficSpotDefinition>> _spots;

		[Ordinal(9)] 
		[RED("patrolPointDefs")] 
		public CArray<CHandle<worldPatrolSplinePointDefinition>> PatrolPointDefs
		{
			get
			{
				if (_patrolPointDefs == null)
				{
					_patrolPointDefs = (CArray<CHandle<worldPatrolSplinePointDefinition>>) CR2WTypeManager.Create("array:handle:worldPatrolSplinePointDefinition", "patrolPointDefs", cr2w, this);
				}
				return _patrolPointDefs;
			}
			set
			{
				if (_patrolPointDefs == value)
				{
					return;
				}
				_patrolPointDefs = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("patrolPoints")] 
		public CArray<NodeRef> PatrolPoints
		{
			get
			{
				if (_patrolPoints == null)
				{
					_patrolPoints = (CArray<NodeRef>) CR2WTypeManager.Create("array:NodeRef", "patrolPoints", cr2w, this);
				}
				return _patrolPoints;
			}
			set
			{
				if (_patrolPoints == value)
				{
					return;
				}
				_patrolPoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("spots")] 
		public CArray<CHandle<worldTrafficSpotDefinition>> Spots
		{
			get
			{
				if (_spots == null)
				{
					_spots = (CArray<CHandle<worldTrafficSpotDefinition>>) CR2WTypeManager.Create("array:handle:worldTrafficSpotDefinition", "spots", cr2w, this);
				}
				return _spots;
			}
			set
			{
				if (_spots == value)
				{
					return;
				}
				_spots = value;
				PropertySet(this);
			}
		}

		public worldPatrolSplineNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

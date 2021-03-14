using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorLineOfSightClearConditionDefinition : AIbehaviorConditionDefinition
	{
		private CArray<CName> _collisionFilters;
		private Vector3 _offset;
		private CHandle<AIArgumentMapping> _target;

		[Ordinal(1)] 
		[RED("collisionFilters")] 
		public CArray<CName> CollisionFilters
		{
			get
			{
				if (_collisionFilters == null)
				{
					_collisionFilters = (CArray<CName>) CR2WTypeManager.Create("array:CName", "collisionFilters", cr2w, this);
				}
				return _collisionFilters;
			}
			set
			{
				if (_collisionFilters == value)
				{
					return;
				}
				_collisionFilters = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (Vector3) CR2WTypeManager.Create("Vector3", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		public AIbehaviorLineOfSightClearConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

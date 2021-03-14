using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIPatrolCommand : AIMoveCommand
	{
		private CHandle<AIPatrolPathParameters> _pathParams;
		private CHandle<AIPatrolPathParameters> _alertedPathParams;
		private CFloat _alertedRadius;
		private CArray<NodeRef> _alertedSpots;
		private CBool _patrolWithWeapon;
		private TweakDBID _patrolAction;

		[Ordinal(7)] 
		[RED("pathParams")] 
		public CHandle<AIPatrolPathParameters> PathParams
		{
			get
			{
				if (_pathParams == null)
				{
					_pathParams = (CHandle<AIPatrolPathParameters>) CR2WTypeManager.Create("handle:AIPatrolPathParameters", "pathParams", cr2w, this);
				}
				return _pathParams;
			}
			set
			{
				if (_pathParams == value)
				{
					return;
				}
				_pathParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("alertedPathParams")] 
		public CHandle<AIPatrolPathParameters> AlertedPathParams
		{
			get
			{
				if (_alertedPathParams == null)
				{
					_alertedPathParams = (CHandle<AIPatrolPathParameters>) CR2WTypeManager.Create("handle:AIPatrolPathParameters", "alertedPathParams", cr2w, this);
				}
				return _alertedPathParams;
			}
			set
			{
				if (_alertedPathParams == value)
				{
					return;
				}
				_alertedPathParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("alertedRadius")] 
		public CFloat AlertedRadius
		{
			get
			{
				if (_alertedRadius == null)
				{
					_alertedRadius = (CFloat) CR2WTypeManager.Create("Float", "alertedRadius", cr2w, this);
				}
				return _alertedRadius;
			}
			set
			{
				if (_alertedRadius == value)
				{
					return;
				}
				_alertedRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("alertedSpots")] 
		public CArray<NodeRef> AlertedSpots
		{
			get
			{
				if (_alertedSpots == null)
				{
					_alertedSpots = (CArray<NodeRef>) CR2WTypeManager.Create("array:NodeRef", "alertedSpots", cr2w, this);
				}
				return _alertedSpots;
			}
			set
			{
				if (_alertedSpots == value)
				{
					return;
				}
				_alertedSpots = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("patrolWithWeapon")] 
		public CBool PatrolWithWeapon
		{
			get
			{
				if (_patrolWithWeapon == null)
				{
					_patrolWithWeapon = (CBool) CR2WTypeManager.Create("Bool", "patrolWithWeapon", cr2w, this);
				}
				return _patrolWithWeapon;
			}
			set
			{
				if (_patrolWithWeapon == value)
				{
					return;
				}
				_patrolWithWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("patrolAction")] 
		public TweakDBID PatrolAction
		{
			get
			{
				if (_patrolAction == null)
				{
					_patrolAction = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "patrolAction", cr2w, this);
				}
				return _patrolAction;
			}
			set
			{
				if (_patrolAction == value)
				{
					return;
				}
				_patrolAction = value;
				PropertySet(this);
			}
		}

		public AIPatrolCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

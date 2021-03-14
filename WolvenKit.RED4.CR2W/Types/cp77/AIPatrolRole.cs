using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIPatrolRole : AIRole
	{
		private CHandle<AIPatrolPathParameters> _pathParams;
		private CHandle<AIPatrolPathParameters> _alertedPathParams;
		private CFloat _alertedRadius;
		private CHandle<AIbehaviorWorkspotList> _alertedSpots;
		private CBool _forceAlerted;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("alertedSpots")] 
		public CHandle<AIbehaviorWorkspotList> AlertedSpots
		{
			get
			{
				if (_alertedSpots == null)
				{
					_alertedSpots = (CHandle<AIbehaviorWorkspotList>) CR2WTypeManager.Create("handle:AIbehaviorWorkspotList", "alertedSpots", cr2w, this);
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

		[Ordinal(4)] 
		[RED("forceAlerted")] 
		public CBool ForceAlerted
		{
			get
			{
				if (_forceAlerted == null)
				{
					_forceAlerted = (CBool) CR2WTypeManager.Create("Bool", "forceAlerted", cr2w, this);
				}
				return _forceAlerted;
			}
			set
			{
				if (_forceAlerted == value)
				{
					return;
				}
				_forceAlerted = value;
				PropertySet(this);
			}
		}

		public AIPatrolRole(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

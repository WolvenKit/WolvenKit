using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorPrepareReservedCrowdWorkspotNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CHandle<AIArgumentMapping> _workspotData;
		private CHandle<AIArgumentMapping> _returnPosition;
		private CHandle<AIArgumentMapping> _returnPositionVector;
		private CHandle<AIArgumentMapping> _workspotExitTangent;
		private CHandle<AIArgumentMapping> _joinTrafficSettings;
		private CHandle<AIArgumentMapping> _overrideExit;

		[Ordinal(1)] 
		[RED("workspotData")] 
		public CHandle<AIArgumentMapping> WorkspotData
		{
			get
			{
				if (_workspotData == null)
				{
					_workspotData = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "workspotData", cr2w, this);
				}
				return _workspotData;
			}
			set
			{
				if (_workspotData == value)
				{
					return;
				}
				_workspotData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("returnPosition")] 
		public CHandle<AIArgumentMapping> ReturnPosition
		{
			get
			{
				if (_returnPosition == null)
				{
					_returnPosition = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "returnPosition", cr2w, this);
				}
				return _returnPosition;
			}
			set
			{
				if (_returnPosition == value)
				{
					return;
				}
				_returnPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("returnPositionVector")] 
		public CHandle<AIArgumentMapping> ReturnPositionVector
		{
			get
			{
				if (_returnPositionVector == null)
				{
					_returnPositionVector = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "returnPositionVector", cr2w, this);
				}
				return _returnPositionVector;
			}
			set
			{
				if (_returnPositionVector == value)
				{
					return;
				}
				_returnPositionVector = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("workspotExitTangent")] 
		public CHandle<AIArgumentMapping> WorkspotExitTangent
		{
			get
			{
				if (_workspotExitTangent == null)
				{
					_workspotExitTangent = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "workspotExitTangent", cr2w, this);
				}
				return _workspotExitTangent;
			}
			set
			{
				if (_workspotExitTangent == value)
				{
					return;
				}
				_workspotExitTangent = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("joinTrafficSettings")] 
		public CHandle<AIArgumentMapping> JoinTrafficSettings
		{
			get
			{
				if (_joinTrafficSettings == null)
				{
					_joinTrafficSettings = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "joinTrafficSettings", cr2w, this);
				}
				return _joinTrafficSettings;
			}
			set
			{
				if (_joinTrafficSettings == value)
				{
					return;
				}
				_joinTrafficSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("overrideExit")] 
		public CHandle<AIArgumentMapping> OverrideExit
		{
			get
			{
				if (_overrideExit == null)
				{
					_overrideExit = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "overrideExit", cr2w, this);
				}
				return _overrideExit;
			}
			set
			{
				if (_overrideExit == value)
				{
					return;
				}
				_overrideExit = value;
				PropertySet(this);
			}
		}

		public AIbehaviorPrepareReservedCrowdWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorPatrolActionNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _path;
		private CHandle<AIArgumentMapping> _patrolProgress;
		private CHandle<AIArgumentMapping> _startFromClosestPoint;
		private CHandle<AIArgumentMapping> _playStartAnimation;
		private CHandle<AIArgumentMapping> _workspotData;
		private CHandle<AIArgumentMapping> _dependentWorkspotData;
		private CHandle<AIArgumentMapping> _lookAtTarget;

		[Ordinal(1)] 
		[RED("path")] 
		public CHandle<AIArgumentMapping> Path
		{
			get
			{
				if (_path == null)
				{
					_path = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "path", cr2w, this);
				}
				return _path;
			}
			set
			{
				if (_path == value)
				{
					return;
				}
				_path = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("patrolProgress")] 
		public CHandle<AIArgumentMapping> PatrolProgress
		{
			get
			{
				if (_patrolProgress == null)
				{
					_patrolProgress = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "patrolProgress", cr2w, this);
				}
				return _patrolProgress;
			}
			set
			{
				if (_patrolProgress == value)
				{
					return;
				}
				_patrolProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("startFromClosestPoint")] 
		public CHandle<AIArgumentMapping> StartFromClosestPoint
		{
			get
			{
				if (_startFromClosestPoint == null)
				{
					_startFromClosestPoint = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "startFromClosestPoint", cr2w, this);
				}
				return _startFromClosestPoint;
			}
			set
			{
				if (_startFromClosestPoint == value)
				{
					return;
				}
				_startFromClosestPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("playStartAnimation")] 
		public CHandle<AIArgumentMapping> PlayStartAnimation
		{
			get
			{
				if (_playStartAnimation == null)
				{
					_playStartAnimation = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "playStartAnimation", cr2w, this);
				}
				return _playStartAnimation;
			}
			set
			{
				if (_playStartAnimation == value)
				{
					return;
				}
				_playStartAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("dependentWorkspotData")] 
		public CHandle<AIArgumentMapping> DependentWorkspotData
		{
			get
			{
				if (_dependentWorkspotData == null)
				{
					_dependentWorkspotData = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "dependentWorkspotData", cr2w, this);
				}
				return _dependentWorkspotData;
			}
			set
			{
				if (_dependentWorkspotData == value)
				{
					return;
				}
				_dependentWorkspotData = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("lookAtTarget")] 
		public CHandle<AIArgumentMapping> LookAtTarget
		{
			get
			{
				if (_lookAtTarget == null)
				{
					_lookAtTarget = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "lookAtTarget", cr2w, this);
				}
				return _lookAtTarget;
			}
			set
			{
				if (_lookAtTarget == value)
				{
					return;
				}
				_lookAtTarget = value;
				PropertySet(this);
			}
		}

		public AIbehaviorPatrolActionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

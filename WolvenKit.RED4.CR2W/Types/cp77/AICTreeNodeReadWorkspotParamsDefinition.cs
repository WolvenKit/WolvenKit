using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeReadWorkspotParamsDefinition : AICTreeNodeDecoratorDefinition
	{
		private CName _workspotNodeVarName;
		private CName _prevWorkspotNodeVarName;
		private CName _splineNodeVarName;
		private CName _workspotEntryAnimVar;
		private CName _animControllerVarName;
		private CName _splineStartAnimVarName;
		private CName _splineStopAnimVarName;
		private CName _moveTargetVarName;

		[Ordinal(1)] 
		[RED("workspotNodeVarName")] 
		public CName WorkspotNodeVarName
		{
			get
			{
				if (_workspotNodeVarName == null)
				{
					_workspotNodeVarName = (CName) CR2WTypeManager.Create("CName", "workspotNodeVarName", cr2w, this);
				}
				return _workspotNodeVarName;
			}
			set
			{
				if (_workspotNodeVarName == value)
				{
					return;
				}
				_workspotNodeVarName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("prevWorkspotNodeVarName")] 
		public CName PrevWorkspotNodeVarName
		{
			get
			{
				if (_prevWorkspotNodeVarName == null)
				{
					_prevWorkspotNodeVarName = (CName) CR2WTypeManager.Create("CName", "prevWorkspotNodeVarName", cr2w, this);
				}
				return _prevWorkspotNodeVarName;
			}
			set
			{
				if (_prevWorkspotNodeVarName == value)
				{
					return;
				}
				_prevWorkspotNodeVarName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("splineNodeVarName")] 
		public CName SplineNodeVarName
		{
			get
			{
				if (_splineNodeVarName == null)
				{
					_splineNodeVarName = (CName) CR2WTypeManager.Create("CName", "splineNodeVarName", cr2w, this);
				}
				return _splineNodeVarName;
			}
			set
			{
				if (_splineNodeVarName == value)
				{
					return;
				}
				_splineNodeVarName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("workspotEntryAnimVar")] 
		public CName WorkspotEntryAnimVar
		{
			get
			{
				if (_workspotEntryAnimVar == null)
				{
					_workspotEntryAnimVar = (CName) CR2WTypeManager.Create("CName", "workspotEntryAnimVar", cr2w, this);
				}
				return _workspotEntryAnimVar;
			}
			set
			{
				if (_workspotEntryAnimVar == value)
				{
					return;
				}
				_workspotEntryAnimVar = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("animControllerVarName")] 
		public CName AnimControllerVarName
		{
			get
			{
				if (_animControllerVarName == null)
				{
					_animControllerVarName = (CName) CR2WTypeManager.Create("CName", "animControllerVarName", cr2w, this);
				}
				return _animControllerVarName;
			}
			set
			{
				if (_animControllerVarName == value)
				{
					return;
				}
				_animControllerVarName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("splineStartAnimVarName")] 
		public CName SplineStartAnimVarName
		{
			get
			{
				if (_splineStartAnimVarName == null)
				{
					_splineStartAnimVarName = (CName) CR2WTypeManager.Create("CName", "splineStartAnimVarName", cr2w, this);
				}
				return _splineStartAnimVarName;
			}
			set
			{
				if (_splineStartAnimVarName == value)
				{
					return;
				}
				_splineStartAnimVarName = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("splineStopAnimVarName")] 
		public CName SplineStopAnimVarName
		{
			get
			{
				if (_splineStopAnimVarName == null)
				{
					_splineStopAnimVarName = (CName) CR2WTypeManager.Create("CName", "splineStopAnimVarName", cr2w, this);
				}
				return _splineStopAnimVarName;
			}
			set
			{
				if (_splineStopAnimVarName == value)
				{
					return;
				}
				_splineStopAnimVarName = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("moveTargetVarName")] 
		public CName MoveTargetVarName
		{
			get
			{
				if (_moveTargetVarName == null)
				{
					_moveTargetVarName = (CName) CR2WTypeManager.Create("CName", "moveTargetVarName", cr2w, this);
				}
				return _moveTargetVarName;
			}
			set
			{
				if (_moveTargetVarName == value)
				{
					return;
				}
				_moveTargetVarName = value;
				PropertySet(this);
			}
		}

		public AICTreeNodeReadWorkspotParamsDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

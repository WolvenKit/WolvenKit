using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTrafficWorkspotTransitionData : ISerializable
	{
		private CHandle<gameSetupWorkspotActionEvent> _workspotData;
		private CHandle<worldTrafficGlobalPathPosition> _returnPosition;
		private Vector3 _workspotExitTangent;
		private Vector3 _trafficLaneReturnTangent;

		[Ordinal(0)] 
		[RED("workspotData")] 
		public CHandle<gameSetupWorkspotActionEvent> WorkspotData
		{
			get
			{
				if (_workspotData == null)
				{
					_workspotData = (CHandle<gameSetupWorkspotActionEvent>) CR2WTypeManager.Create("handle:gameSetupWorkspotActionEvent", "workspotData", cr2w, this);
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

		[Ordinal(1)] 
		[RED("returnPosition")] 
		public CHandle<worldTrafficGlobalPathPosition> ReturnPosition
		{
			get
			{
				if (_returnPosition == null)
				{
					_returnPosition = (CHandle<worldTrafficGlobalPathPosition>) CR2WTypeManager.Create("handle:worldTrafficGlobalPathPosition", "returnPosition", cr2w, this);
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

		[Ordinal(2)] 
		[RED("workspotExitTangent")] 
		public Vector3 WorkspotExitTangent
		{
			get
			{
				if (_workspotExitTangent == null)
				{
					_workspotExitTangent = (Vector3) CR2WTypeManager.Create("Vector3", "workspotExitTangent", cr2w, this);
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

		[Ordinal(3)] 
		[RED("trafficLaneReturnTangent")] 
		public Vector3 TrafficLaneReturnTangent
		{
			get
			{
				if (_trafficLaneReturnTangent == null)
				{
					_trafficLaneReturnTangent = (Vector3) CR2WTypeManager.Create("Vector3", "trafficLaneReturnTangent", cr2w, this);
				}
				return _trafficLaneReturnTangent;
			}
			set
			{
				if (_trafficLaneReturnTangent == value)
				{
					return;
				}
				_trafficLaneReturnTangent = value;
				PropertySet(this);
			}
		}

		public gameTrafficWorkspotTransitionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

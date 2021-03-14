using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorkspotMapData : IScriptable
	{
		private CEnum<gamedataWorkspotActionType> _action;
		private CArray<CHandle<WorkspotEntryData>> _workspots;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<gamedataWorkspotActionType> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CEnum<gamedataWorkspotActionType>) CR2WTypeManager.Create("gamedataWorkspotActionType", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("workspots")] 
		public CArray<CHandle<WorkspotEntryData>> Workspots
		{
			get
			{
				if (_workspots == null)
				{
					_workspots = (CArray<CHandle<WorkspotEntryData>>) CR2WTypeManager.Create("array:handle:WorkspotEntryData", "workspots", cr2w, this);
				}
				return _workspots;
			}
			set
			{
				if (_workspots == value)
				{
					return;
				}
				_workspots = value;
				PropertySet(this);
			}
		}

		public WorkspotMapData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

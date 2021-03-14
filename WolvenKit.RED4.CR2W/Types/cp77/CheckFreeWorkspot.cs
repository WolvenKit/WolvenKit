using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckFreeWorkspot : AIbehaviorconditionScript
	{
		private CEnum<gamedataWorkspotActionType> _aIAction;
		private wCHandle<gameObject> _workspotObject;
		private CHandle<WorkspotEntryData> _workspotData;
		private worldGlobalNodeRef _globalRef;

		[Ordinal(0)] 
		[RED("AIAction")] 
		public CEnum<gamedataWorkspotActionType> AIAction
		{
			get
			{
				if (_aIAction == null)
				{
					_aIAction = (CEnum<gamedataWorkspotActionType>) CR2WTypeManager.Create("gamedataWorkspotActionType", "AIAction", cr2w, this);
				}
				return _aIAction;
			}
			set
			{
				if (_aIAction == value)
				{
					return;
				}
				_aIAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("workspotObject")] 
		public wCHandle<gameObject> WorkspotObject
		{
			get
			{
				if (_workspotObject == null)
				{
					_workspotObject = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "workspotObject", cr2w, this);
				}
				return _workspotObject;
			}
			set
			{
				if (_workspotObject == value)
				{
					return;
				}
				_workspotObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("workspotData")] 
		public CHandle<WorkspotEntryData> WorkspotData
		{
			get
			{
				if (_workspotData == null)
				{
					_workspotData = (CHandle<WorkspotEntryData>) CR2WTypeManager.Create("handle:WorkspotEntryData", "workspotData", cr2w, this);
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

		[Ordinal(3)] 
		[RED("globalRef")] 
		public worldGlobalNodeRef GlobalRef
		{
			get
			{
				if (_globalRef == null)
				{
					_globalRef = (worldGlobalNodeRef) CR2WTypeManager.Create("worldGlobalNodeRef", "globalRef", cr2w, this);
				}
				return _globalRef;
			}
			set
			{
				if (_globalRef == value)
				{
					return;
				}
				_globalRef = value;
				PropertySet(this);
			}
		}

		public CheckFreeWorkspot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

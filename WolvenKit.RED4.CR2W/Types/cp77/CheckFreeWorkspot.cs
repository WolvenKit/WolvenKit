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
			get => GetProperty(ref _aIAction);
			set => SetProperty(ref _aIAction, value);
		}

		[Ordinal(1)] 
		[RED("workspotObject")] 
		public wCHandle<gameObject> WorkspotObject
		{
			get => GetProperty(ref _workspotObject);
			set => SetProperty(ref _workspotObject, value);
		}

		[Ordinal(2)] 
		[RED("workspotData")] 
		public CHandle<WorkspotEntryData> WorkspotData
		{
			get => GetProperty(ref _workspotData);
			set => SetProperty(ref _workspotData, value);
		}

		[Ordinal(3)] 
		[RED("globalRef")] 
		public worldGlobalNodeRef GlobalRef
		{
			get => GetProperty(ref _globalRef);
			set => SetProperty(ref _globalRef, value);
		}

		public CheckFreeWorkspot(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

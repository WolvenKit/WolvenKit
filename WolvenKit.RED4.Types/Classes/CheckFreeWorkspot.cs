using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckFreeWorkspot : AIbehaviorconditionScript
	{
		private CEnum<gamedataWorkspotActionType> _aIAction;
		private CWeakHandle<gameObject> _workspotObject;
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
		public CWeakHandle<gameObject> WorkspotObject
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
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckFreeWorkspot : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("AIAction")] 
		public CEnum<gamedataWorkspotActionType> AIAction
		{
			get => GetPropertyValue<CEnum<gamedataWorkspotActionType>>();
			set => SetPropertyValue<CEnum<gamedataWorkspotActionType>>(value);
		}

		[Ordinal(1)] 
		[RED("workspotObject")] 
		public CWeakHandle<gameObject> WorkspotObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(2)] 
		[RED("workspotData")] 
		public CHandle<WorkspotEntryData> WorkspotData
		{
			get => GetPropertyValue<CHandle<WorkspotEntryData>>();
			set => SetPropertyValue<CHandle<WorkspotEntryData>>(value);
		}

		[Ordinal(3)] 
		[RED("globalRef")] 
		public worldGlobalNodeRef GlobalRef
		{
			get => GetPropertyValue<worldGlobalNodeRef>();
			set => SetPropertyValue<worldGlobalNodeRef>(value);
		}

		public CheckFreeWorkspot()
		{
			GlobalRef = new worldGlobalNodeRef();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

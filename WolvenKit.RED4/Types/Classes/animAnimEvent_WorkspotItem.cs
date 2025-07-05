using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimEvent_WorkspotItem : animAnimEvent
	{
		[Ordinal(3)] 
		[RED("actions")] 
		public CArray<CHandle<workIWorkspotItemAction>> Actions
		{
			get => GetPropertyValue<CArray<CHandle<workIWorkspotItemAction>>>();
			set => SetPropertyValue<CArray<CHandle<workIWorkspotItemAction>>>(value);
		}

		public animAnimEvent_WorkspotItem()
		{
			Actions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimEvent_WorkspotItem : animAnimEvent
	{
		private CArray<CHandle<workIWorkspotItemAction>> _actions;

		[Ordinal(3)] 
		[RED("actions")] 
		public CArray<CHandle<workIWorkspotItemAction>> Actions
		{
			get => GetProperty(ref _actions);
			set => SetProperty(ref _actions, value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FailedActionEvent : redEvent
	{
		private CHandle<gamedeviceAction> _action;
		private gamePersistentID _whoFailed;

		[Ordinal(0)] 
		[RED("action")] 
		public CHandle<gamedeviceAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(1)] 
		[RED("whoFailed")] 
		public gamePersistentID WhoFailed
		{
			get => GetProperty(ref _whoFailed);
			set => SetProperty(ref _whoFailed, value);
		}
	}
}

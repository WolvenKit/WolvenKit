using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PauseMenuListItemData : ListItemData
	{
		private CName _eventName;
		private CEnum<PauseMenuAction> _action;

		[Ordinal(1)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetProperty(ref _eventName);
			set => SetProperty(ref _eventName, value);
		}

		[Ordinal(2)] 
		[RED("action")] 
		public CEnum<PauseMenuAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}
	}
}

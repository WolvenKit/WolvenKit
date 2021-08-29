using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiGenericNotificationViewData : IScriptable
	{
		private CString _title;
		private CString _text;
		private CName _soundEvent;
		private CName _soundAction;
		private CHandle<GenericNotificationBaseAction> _action;

		[Ordinal(0)] 
		[RED("title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(1)] 
		[RED("text")] 
		public CString Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(2)] 
		[RED("soundEvent")] 
		public CName SoundEvent
		{
			get => GetProperty(ref _soundEvent);
			set => SetProperty(ref _soundEvent, value);
		}

		[Ordinal(3)] 
		[RED("soundAction")] 
		public CName SoundAction
		{
			get => GetProperty(ref _soundAction);
			set => SetProperty(ref _soundAction, value);
		}

		[Ordinal(4)] 
		[RED("action")] 
		public CHandle<GenericNotificationBaseAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}
	}
}

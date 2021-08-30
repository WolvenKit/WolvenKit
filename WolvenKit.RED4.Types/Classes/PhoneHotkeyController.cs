using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PhoneHotkeyController : GenericHotkeyController
	{
		private inkImageWidgetReference _mainIcon;
		private inkTextWidgetReference _messagePrompt;
		private inkTextWidgetReference _messageCounter;
		private CWeakHandle<gameJournalManager> _journalManager;
		private CString _phoneIconAtlas;
		private CName _phoneIconName;

		[Ordinal(19)] 
		[RED("mainIcon")] 
		public inkImageWidgetReference MainIcon
		{
			get => GetProperty(ref _mainIcon);
			set => SetProperty(ref _mainIcon, value);
		}

		[Ordinal(20)] 
		[RED("messagePrompt")] 
		public inkTextWidgetReference MessagePrompt
		{
			get => GetProperty(ref _messagePrompt);
			set => SetProperty(ref _messagePrompt, value);
		}

		[Ordinal(21)] 
		[RED("messageCounter")] 
		public inkTextWidgetReference MessageCounter
		{
			get => GetProperty(ref _messageCounter);
			set => SetProperty(ref _messageCounter, value);
		}

		[Ordinal(22)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(23)] 
		[RED("phoneIconAtlas")] 
		public CString PhoneIconAtlas
		{
			get => GetProperty(ref _phoneIconAtlas);
			set => SetProperty(ref _phoneIconAtlas, value);
		}

		[Ordinal(24)] 
		[RED("phoneIconName")] 
		public CName PhoneIconName
		{
			get => GetProperty(ref _phoneIconName);
			set => SetProperty(ref _phoneIconName, value);
		}

		public PhoneHotkeyController()
		{
			_phoneIconAtlas = new() { Text = @"base\gameplay\gui\common\icons\atlas_common.inkatlas" };
			_phoneIconName = "ico_phone";
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhoneHotkeyController : GenericHotkeyController
	{
		[Ordinal(19)] 
		[RED("mainIcon")] 
		public inkImageWidgetReference MainIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("messagePrompt")] 
		public inkTextWidgetReference MessagePrompt
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("messageCounter")] 
		public inkTextWidgetReference MessageCounter
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(23)] 
		[RED("phoneIconAtlas")] 
		public CString PhoneIconAtlas
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(24)] 
		[RED("phoneIconName")] 
		public CName PhoneIconName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public PhoneHotkeyController()
		{
			HotkeyBackground = new inkImageWidgetReference();
			ButtonHint = new inkWidgetReference();
			Restrictions = new();
			DebugCommands = new();
			MainIcon = new inkImageWidgetReference();
			MessagePrompt = new inkTextWidgetReference();
			MessageCounter = new inkTextWidgetReference();
			PhoneIconAtlas = "base\\gameplay\\gui\\common\\icons\\atlas_common.inkatlas";
			PhoneIconName = "ico_phone";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

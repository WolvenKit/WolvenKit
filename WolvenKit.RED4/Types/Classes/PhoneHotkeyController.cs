using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhoneHotkeyController : GenericHotkeyController
	{
		[Ordinal(25)] 
		[RED("mainIcon")] 
		public inkImageWidgetReference MainIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("questIcon")] 
		public inkImageWidgetReference QuestIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("callIcon")] 
		public inkImageWidgetReference CallIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("messageCounterLabel")] 
		public inkWidgetReference MessageCounterLabel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("messageCounterLabelCircle")] 
		public inkWidgetReference MessageCounterLabelCircle
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("messageCounter")] 
		public inkTextWidgetReference MessageCounter
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("messageCounterCircle")] 
		public inkTextWidgetReference MessageCounterCircle
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(33)] 
		[RED("phoneIconAtlas")] 
		public CString PhoneIconAtlas
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(34)] 
		[RED("phoneIconName")] 
		public CName PhoneIconName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(35)] 
		[RED("proxy")] 
		public CHandle<inkanimProxy> Proxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(36)] 
		[RED("questImportantAnimProxy")] 
		public CHandle<inkanimProxy> QuestImportantAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(37)] 
		[RED("comDeviceBB")] 
		public CWeakHandle<gameIBlackboard> ComDeviceBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(38)] 
		[RED("quickSlotBB")] 
		public CWeakHandle<gameIBlackboard> QuickSlotBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(39)] 
		[RED("phoneEnabledBBId")] 
		public CHandle<redCallbackObject> PhoneEnabledBBId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(40)] 
		[RED("isVehiclesPopupVisibleBBId")] 
		public CHandle<redCallbackObject> IsVehiclesPopupVisibleBBId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(41)] 
		[RED("isRadioPopupVisibleBBId")] 
		public CHandle<redCallbackObject> IsRadioPopupVisibleBBId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(42)] 
		[RED("isRadialMenuVisibleBBId")] 
		public CHandle<redCallbackObject> IsRadialMenuVisibleBBId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(43)] 
		[RED("cinematicCameraBBId")] 
		public CHandle<redCallbackObject> CinematicCameraBBId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public PhoneHotkeyController()
		{
			HotkeyBackground = new inkImageWidgetReference();
			ButtonHint = new inkWidgetReference();
			Restrictions = new();
			DebugCommands = new();
			MainIcon = new inkImageWidgetReference();
			QuestIcon = new inkImageWidgetReference();
			CallIcon = new inkImageWidgetReference();
			MessageCounterLabel = new inkWidgetReference();
			MessageCounterLabelCircle = new inkWidgetReference();
			MessageCounter = new inkTextWidgetReference();
			MessageCounterCircle = new inkTextWidgetReference();
			PhoneIconAtlas = "base\\gameplay\\gui\\common\\icons\\atlas_common.inkatlas";
			PhoneIconName = "ico_phone";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

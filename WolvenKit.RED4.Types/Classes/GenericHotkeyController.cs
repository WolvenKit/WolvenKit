using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GenericHotkeyController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("hotkeyBackground")] 
		public inkImageWidgetReference HotkeyBackground
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("buttonHint")] 
		public inkWidgetReference ButtonHint
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("hotkey")] 
		public CEnum<gameEHotkey> Hotkey
		{
			get => GetPropertyValue<CEnum<gameEHotkey>>();
			set => SetPropertyValue<CEnum<gameEHotkey>>(value);
		}

		[Ordinal(12)] 
		[RED("pressStarted")] 
		public CBool PressStarted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("buttonHintController")] 
		public CWeakHandle<inkInputDisplayController> ButtonHintController
		{
			get => GetPropertyValue<CWeakHandle<inkInputDisplayController>>();
			set => SetPropertyValue<CWeakHandle<inkInputDisplayController>>(value);
		}

		[Ordinal(14)] 
		[RED("questActivatingFact")] 
		public CName QuestActivatingFact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("restrictions")] 
		public CArray<CName> Restrictions
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(16)] 
		[RED("statusEffectsListener")] 
		public CHandle<HotkeyWidgetStatsListener> StatusEffectsListener
		{
			get => GetPropertyValue<CHandle<HotkeyWidgetStatsListener>>();
			set => SetPropertyValue<CHandle<HotkeyWidgetStatsListener>>(value);
		}

		[Ordinal(17)] 
		[RED("debugCommands")] 
		public CArray<CUInt32> DebugCommands
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(18)] 
		[RED("factListenerId")] 
		public CUInt32 FactListenerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public GenericHotkeyController()
		{
			ShowAnimationName = "unfold";
			HideAnimationName = "fold";
		}
	}
}

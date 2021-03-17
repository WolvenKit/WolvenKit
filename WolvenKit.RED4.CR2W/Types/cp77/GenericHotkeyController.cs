using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericHotkeyController : gameuiHUDGameController
	{
		private inkImageWidgetReference _hotkeyBackground;
		private inkWidgetReference _buttonHint;
		private CEnum<gameEHotkey> _hotkey;
		private CBool _pressStarted;
		private CHandle<inkInputDisplayController> _buttonHintController;
		private CName _questActivatingFact;
		private CArray<CName> _restrictions;
		private CHandle<HotkeyWidgetStatsListener> _statusEffectsListener;
		private CArray<CUInt32> _debugCommands;
		private CUInt32 _factListenerId;

		[Ordinal(9)] 
		[RED("hotkeyBackground")] 
		public inkImageWidgetReference HotkeyBackground
		{
			get => GetProperty(ref _hotkeyBackground);
			set => SetProperty(ref _hotkeyBackground, value);
		}

		[Ordinal(10)] 
		[RED("buttonHint")] 
		public inkWidgetReference ButtonHint
		{
			get => GetProperty(ref _buttonHint);
			set => SetProperty(ref _buttonHint, value);
		}

		[Ordinal(11)] 
		[RED("hotkey")] 
		public CEnum<gameEHotkey> Hotkey
		{
			get => GetProperty(ref _hotkey);
			set => SetProperty(ref _hotkey, value);
		}

		[Ordinal(12)] 
		[RED("pressStarted")] 
		public CBool PressStarted
		{
			get => GetProperty(ref _pressStarted);
			set => SetProperty(ref _pressStarted, value);
		}

		[Ordinal(13)] 
		[RED("buttonHintController")] 
		public CHandle<inkInputDisplayController> ButtonHintController
		{
			get => GetProperty(ref _buttonHintController);
			set => SetProperty(ref _buttonHintController, value);
		}

		[Ordinal(14)] 
		[RED("questActivatingFact")] 
		public CName QuestActivatingFact
		{
			get => GetProperty(ref _questActivatingFact);
			set => SetProperty(ref _questActivatingFact, value);
		}

		[Ordinal(15)] 
		[RED("restrictions")] 
		public CArray<CName> Restrictions
		{
			get => GetProperty(ref _restrictions);
			set => SetProperty(ref _restrictions, value);
		}

		[Ordinal(16)] 
		[RED("statusEffectsListener")] 
		public CHandle<HotkeyWidgetStatsListener> StatusEffectsListener
		{
			get => GetProperty(ref _statusEffectsListener);
			set => SetProperty(ref _statusEffectsListener, value);
		}

		[Ordinal(17)] 
		[RED("debugCommands")] 
		public CArray<CUInt32> DebugCommands
		{
			get => GetProperty(ref _debugCommands);
			set => SetProperty(ref _debugCommands, value);
		}

		[Ordinal(18)] 
		[RED("factListenerId")] 
		public CUInt32 FactListenerId
		{
			get => GetProperty(ref _factListenerId);
			set => SetProperty(ref _factListenerId, value);
		}

		public GenericHotkeyController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

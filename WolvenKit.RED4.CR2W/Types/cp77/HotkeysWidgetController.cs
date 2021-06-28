using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HotkeysWidgetController : gameuiHUDGameController
	{
		private inkHorizontalPanelWidgetReference _hotkeysList;
		private inkHorizontalPanelWidgetReference _utilsList;
		private wCHandle<inkWidget> _phone;
		private wCHandle<inkWidget> _car;
		private wCHandle<inkWidget> _consumables;
		private wCHandle<inkWidget> _gadgets;
		private wCHandle<PlayerPuppet> _player;
		private wCHandle<inkCompoundWidget> _root;
		private ScriptGameInstance _gameInstance;
		private CUInt32 _fact1ListenerId;
		private CUInt32 _fact2ListenerId;

		[Ordinal(9)] 
		[RED("hotkeysList")] 
		public inkHorizontalPanelWidgetReference HotkeysList
		{
			get => GetProperty(ref _hotkeysList);
			set => SetProperty(ref _hotkeysList, value);
		}

		[Ordinal(10)] 
		[RED("utilsList")] 
		public inkHorizontalPanelWidgetReference UtilsList
		{
			get => GetProperty(ref _utilsList);
			set => SetProperty(ref _utilsList, value);
		}

		[Ordinal(11)] 
		[RED("phone")] 
		public wCHandle<inkWidget> Phone
		{
			get => GetProperty(ref _phone);
			set => SetProperty(ref _phone, value);
		}

		[Ordinal(12)] 
		[RED("car")] 
		public wCHandle<inkWidget> Car
		{
			get => GetProperty(ref _car);
			set => SetProperty(ref _car, value);
		}

		[Ordinal(13)] 
		[RED("consumables")] 
		public wCHandle<inkWidget> Consumables
		{
			get => GetProperty(ref _consumables);
			set => SetProperty(ref _consumables, value);
		}

		[Ordinal(14)] 
		[RED("gadgets")] 
		public wCHandle<inkWidget> Gadgets
		{
			get => GetProperty(ref _gadgets);
			set => SetProperty(ref _gadgets, value);
		}

		[Ordinal(15)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(16)] 
		[RED("root")] 
		public wCHandle<inkCompoundWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(17)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(18)] 
		[RED("fact1ListenerId")] 
		public CUInt32 Fact1ListenerId
		{
			get => GetProperty(ref _fact1ListenerId);
			set => SetProperty(ref _fact1ListenerId, value);
		}

		[Ordinal(19)] 
		[RED("fact2ListenerId")] 
		public CUInt32 Fact2ListenerId
		{
			get => GetProperty(ref _fact2ListenerId);
			set => SetProperty(ref _fact2ListenerId, value);
		}

		public HotkeysWidgetController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

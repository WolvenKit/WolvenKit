using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HotkeysWidgetController : gameuiHUDGameController
	{
		private inkHorizontalPanelWidgetReference _hotkeysList;
		private inkHorizontalPanelWidgetReference _utilsList;
		private CWeakHandle<inkWidget> _phone;
		private CWeakHandle<inkWidget> _car;
		private CWeakHandle<inkWidget> _consumables;
		private CWeakHandle<inkWidget> _gadgets;
		private CWeakHandle<PlayerPuppet> _player;
		private CWeakHandle<inkCompoundWidget> _root;
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
		public CWeakHandle<inkWidget> Phone
		{
			get => GetProperty(ref _phone);
			set => SetProperty(ref _phone, value);
		}

		[Ordinal(12)] 
		[RED("car")] 
		public CWeakHandle<inkWidget> Car
		{
			get => GetProperty(ref _car);
			set => SetProperty(ref _car, value);
		}

		[Ordinal(13)] 
		[RED("consumables")] 
		public CWeakHandle<inkWidget> Consumables
		{
			get => GetProperty(ref _consumables);
			set => SetProperty(ref _consumables, value);
		}

		[Ordinal(14)] 
		[RED("gadgets")] 
		public CWeakHandle<inkWidget> Gadgets
		{
			get => GetProperty(ref _gadgets);
			set => SetProperty(ref _gadgets, value);
		}

		[Ordinal(15)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(16)] 
		[RED("root")] 
		public CWeakHandle<inkCompoundWidget> Root
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
	}
}

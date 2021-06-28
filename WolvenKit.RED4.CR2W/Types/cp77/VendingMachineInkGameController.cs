using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendingMachineInkGameController : DeviceInkGameControllerBase
	{
		private inkHorizontalPanelWidgetReference _actionsPanel;
		private inkTextWidgetReference _priceText;
		private inkCompoundWidgetReference _noMoneyPanel;
		private inkCompoundWidgetReference _soldOutPanel;
		private CEnum<PaymentStatus> _state;
		private CBool _soldOut;
		private CUInt32 _onUpdateStatusListener;
		private CUInt32 _onGlitchingStateChangedListener;
		private CUInt32 _onSoldOutListener;

		[Ordinal(16)] 
		[RED("ActionsPanel")] 
		public inkHorizontalPanelWidgetReference ActionsPanel
		{
			get => GetProperty(ref _actionsPanel);
			set => SetProperty(ref _actionsPanel, value);
		}

		[Ordinal(17)] 
		[RED("priceText")] 
		public inkTextWidgetReference PriceText
		{
			get => GetProperty(ref _priceText);
			set => SetProperty(ref _priceText, value);
		}

		[Ordinal(18)] 
		[RED("noMoneyPanel")] 
		public inkCompoundWidgetReference NoMoneyPanel
		{
			get => GetProperty(ref _noMoneyPanel);
			set => SetProperty(ref _noMoneyPanel, value);
		}

		[Ordinal(19)] 
		[RED("soldOutPanel")] 
		public inkCompoundWidgetReference SoldOutPanel
		{
			get => GetProperty(ref _soldOutPanel);
			set => SetProperty(ref _soldOutPanel, value);
		}

		[Ordinal(20)] 
		[RED("state")] 
		public CEnum<PaymentStatus> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(21)] 
		[RED("soldOut")] 
		public CBool SoldOut
		{
			get => GetProperty(ref _soldOut);
			set => SetProperty(ref _soldOut, value);
		}

		[Ordinal(22)] 
		[RED("onUpdateStatusListener")] 
		public CUInt32 OnUpdateStatusListener
		{
			get => GetProperty(ref _onUpdateStatusListener);
			set => SetProperty(ref _onUpdateStatusListener, value);
		}

		[Ordinal(23)] 
		[RED("onGlitchingStateChangedListener")] 
		public CUInt32 OnGlitchingStateChangedListener
		{
			get => GetProperty(ref _onGlitchingStateChangedListener);
			set => SetProperty(ref _onGlitchingStateChangedListener, value);
		}

		[Ordinal(24)] 
		[RED("onSoldOutListener")] 
		public CUInt32 OnSoldOutListener
		{
			get => GetProperty(ref _onSoldOutListener);
			set => SetProperty(ref _onSoldOutListener, value);
		}

		public VendingMachineInkGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

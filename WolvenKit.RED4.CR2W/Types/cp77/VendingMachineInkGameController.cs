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
			get
			{
				if (_actionsPanel == null)
				{
					_actionsPanel = (inkHorizontalPanelWidgetReference) CR2WTypeManager.Create("inkHorizontalPanelWidgetReference", "ActionsPanel", cr2w, this);
				}
				return _actionsPanel;
			}
			set
			{
				if (_actionsPanel == value)
				{
					return;
				}
				_actionsPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("priceText")] 
		public inkTextWidgetReference PriceText
		{
			get
			{
				if (_priceText == null)
				{
					_priceText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "priceText", cr2w, this);
				}
				return _priceText;
			}
			set
			{
				if (_priceText == value)
				{
					return;
				}
				_priceText = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("noMoneyPanel")] 
		public inkCompoundWidgetReference NoMoneyPanel
		{
			get
			{
				if (_noMoneyPanel == null)
				{
					_noMoneyPanel = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "noMoneyPanel", cr2w, this);
				}
				return _noMoneyPanel;
			}
			set
			{
				if (_noMoneyPanel == value)
				{
					return;
				}
				_noMoneyPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("soldOutPanel")] 
		public inkCompoundWidgetReference SoldOutPanel
		{
			get
			{
				if (_soldOutPanel == null)
				{
					_soldOutPanel = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "soldOutPanel", cr2w, this);
				}
				return _soldOutPanel;
			}
			set
			{
				if (_soldOutPanel == value)
				{
					return;
				}
				_soldOutPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("state")] 
		public CEnum<PaymentStatus> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<PaymentStatus>) CR2WTypeManager.Create("PaymentStatus", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("soldOut")] 
		public CBool SoldOut
		{
			get
			{
				if (_soldOut == null)
				{
					_soldOut = (CBool) CR2WTypeManager.Create("Bool", "soldOut", cr2w, this);
				}
				return _soldOut;
			}
			set
			{
				if (_soldOut == value)
				{
					return;
				}
				_soldOut = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("onUpdateStatusListener")] 
		public CUInt32 OnUpdateStatusListener
		{
			get
			{
				if (_onUpdateStatusListener == null)
				{
					_onUpdateStatusListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onUpdateStatusListener", cr2w, this);
				}
				return _onUpdateStatusListener;
			}
			set
			{
				if (_onUpdateStatusListener == value)
				{
					return;
				}
				_onUpdateStatusListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("onGlitchingStateChangedListener")] 
		public CUInt32 OnGlitchingStateChangedListener
		{
			get
			{
				if (_onGlitchingStateChangedListener == null)
				{
					_onGlitchingStateChangedListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onGlitchingStateChangedListener", cr2w, this);
				}
				return _onGlitchingStateChangedListener;
			}
			set
			{
				if (_onGlitchingStateChangedListener == value)
				{
					return;
				}
				_onGlitchingStateChangedListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("onSoldOutListener")] 
		public CUInt32 OnSoldOutListener
		{
			get
			{
				if (_onSoldOutListener == null)
				{
					_onSoldOutListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onSoldOutListener", cr2w, this);
				}
				return _onSoldOutListener;
			}
			set
			{
				if (_onSoldOutListener == value)
				{
					return;
				}
				_onSoldOutListener = value;
				PropertySet(this);
			}
		}

		public VendingMachineInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

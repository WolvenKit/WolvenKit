using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PayActionWidgetController : DeviceActionWidgetControllerBase
	{
		private inkWidgetReference _priceContainer;
		private inkWidgetReference _moneyStatusContainer;
		private inkWidgetReference _processingStatusContainer;
		private CName _moneyStatusAnimName;
		private CName _processingAnimName;
		private CBool _isProcessingPayment;

		[Ordinal(28)] 
		[RED("priceContainer")] 
		public inkWidgetReference PriceContainer
		{
			get
			{
				if (_priceContainer == null)
				{
					_priceContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "priceContainer", cr2w, this);
				}
				return _priceContainer;
			}
			set
			{
				if (_priceContainer == value)
				{
					return;
				}
				_priceContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("moneyStatusContainer")] 
		public inkWidgetReference MoneyStatusContainer
		{
			get
			{
				if (_moneyStatusContainer == null)
				{
					_moneyStatusContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "moneyStatusContainer", cr2w, this);
				}
				return _moneyStatusContainer;
			}
			set
			{
				if (_moneyStatusContainer == value)
				{
					return;
				}
				_moneyStatusContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("processingStatusContainer")] 
		public inkWidgetReference ProcessingStatusContainer
		{
			get
			{
				if (_processingStatusContainer == null)
				{
					_processingStatusContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "processingStatusContainer", cr2w, this);
				}
				return _processingStatusContainer;
			}
			set
			{
				if (_processingStatusContainer == value)
				{
					return;
				}
				_processingStatusContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("moneyStatusAnimName")] 
		public CName MoneyStatusAnimName
		{
			get
			{
				if (_moneyStatusAnimName == null)
				{
					_moneyStatusAnimName = (CName) CR2WTypeManager.Create("CName", "moneyStatusAnimName", cr2w, this);
				}
				return _moneyStatusAnimName;
			}
			set
			{
				if (_moneyStatusAnimName == value)
				{
					return;
				}
				_moneyStatusAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("processingAnimName")] 
		public CName ProcessingAnimName
		{
			get
			{
				if (_processingAnimName == null)
				{
					_processingAnimName = (CName) CR2WTypeManager.Create("CName", "processingAnimName", cr2w, this);
				}
				return _processingAnimName;
			}
			set
			{
				if (_processingAnimName == value)
				{
					return;
				}
				_processingAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("isProcessingPayment")] 
		public CBool IsProcessingPayment
		{
			get
			{
				if (_isProcessingPayment == null)
				{
					_isProcessingPayment = (CBool) CR2WTypeManager.Create("Bool", "isProcessingPayment", cr2w, this);
				}
				return _isProcessingPayment;
			}
			set
			{
				if (_isProcessingPayment == value)
				{
					return;
				}
				_isProcessingPayment = value;
				PropertySet(this);
			}
		}

		public PayActionWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

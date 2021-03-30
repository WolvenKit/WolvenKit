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

		[Ordinal(29)] 
		[RED("priceContainer")] 
		public inkWidgetReference PriceContainer
		{
			get => GetProperty(ref _priceContainer);
			set => SetProperty(ref _priceContainer, value);
		}

		[Ordinal(30)] 
		[RED("moneyStatusContainer")] 
		public inkWidgetReference MoneyStatusContainer
		{
			get => GetProperty(ref _moneyStatusContainer);
			set => SetProperty(ref _moneyStatusContainer, value);
		}

		[Ordinal(31)] 
		[RED("processingStatusContainer")] 
		public inkWidgetReference ProcessingStatusContainer
		{
			get => GetProperty(ref _processingStatusContainer);
			set => SetProperty(ref _processingStatusContainer, value);
		}

		[Ordinal(32)] 
		[RED("moneyStatusAnimName")] 
		public CName MoneyStatusAnimName
		{
			get => GetProperty(ref _moneyStatusAnimName);
			set => SetProperty(ref _moneyStatusAnimName, value);
		}

		[Ordinal(33)] 
		[RED("processingAnimName")] 
		public CName ProcessingAnimName
		{
			get => GetProperty(ref _processingAnimName);
			set => SetProperty(ref _processingAnimName, value);
		}

		[Ordinal(34)] 
		[RED("isProcessingPayment")] 
		public CBool IsProcessingPayment
		{
			get => GetProperty(ref _isProcessingPayment);
			set => SetProperty(ref _isProcessingPayment, value);
		}

		public PayActionWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPaymentConditionData : CVariable
	{
		private CBool _isInverted;
		private gameItemID _paymentItemId;
		private CUInt32 _paymentAmount;

		[Ordinal(0)] 
		[RED("isInverted")] 
		public CBool IsInverted
		{
			get => GetProperty(ref _isInverted);
			set => SetProperty(ref _isInverted, value);
		}

		[Ordinal(1)] 
		[RED("paymentItemId")] 
		public gameItemID PaymentItemId
		{
			get => GetProperty(ref _paymentItemId);
			set => SetProperty(ref _paymentItemId, value);
		}

		[Ordinal(2)] 
		[RED("paymentAmount")] 
		public CUInt32 PaymentAmount
		{
			get => GetProperty(ref _paymentAmount);
			set => SetProperty(ref _paymentAmount, value);
		}

		public questPaymentConditionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

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
			get
			{
				if (_isInverted == null)
				{
					_isInverted = (CBool) CR2WTypeManager.Create("Bool", "isInverted", cr2w, this);
				}
				return _isInverted;
			}
			set
			{
				if (_isInverted == value)
				{
					return;
				}
				_isInverted = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("paymentItemId")] 
		public gameItemID PaymentItemId
		{
			get
			{
				if (_paymentItemId == null)
				{
					_paymentItemId = (gameItemID) CR2WTypeManager.Create("gameItemID", "paymentItemId", cr2w, this);
				}
				return _paymentItemId;
			}
			set
			{
				if (_paymentItemId == value)
				{
					return;
				}
				_paymentItemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("paymentAmount")] 
		public CUInt32 PaymentAmount
		{
			get
			{
				if (_paymentAmount == null)
				{
					_paymentAmount = (CUInt32) CR2WTypeManager.Create("Uint32", "paymentAmount", cr2w, this);
				}
				return _paymentAmount;
			}
			set
			{
				if (_paymentAmount == value)
				{
					return;
				}
				_paymentAmount = value;
				PropertySet(this);
			}
		}

		public questPaymentConditionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

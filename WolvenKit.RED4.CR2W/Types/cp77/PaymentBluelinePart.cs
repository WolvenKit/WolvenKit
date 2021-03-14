using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PaymentBluelinePart : gameinteractionsvisBluelinePart
	{
		private CInt32 _playerMoney;
		private CInt32 _paymentMoney;

		[Ordinal(2)] 
		[RED("playerMoney")] 
		public CInt32 PlayerMoney
		{
			get
			{
				if (_playerMoney == null)
				{
					_playerMoney = (CInt32) CR2WTypeManager.Create("Int32", "playerMoney", cr2w, this);
				}
				return _playerMoney;
			}
			set
			{
				if (_playerMoney == value)
				{
					return;
				}
				_playerMoney = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("paymentMoney")] 
		public CInt32 PaymentMoney
		{
			get
			{
				if (_paymentMoney == null)
				{
					_paymentMoney = (CInt32) CR2WTypeManager.Create("Int32", "paymentMoney", cr2w, this);
				}
				return _paymentMoney;
			}
			set
			{
				if (_paymentMoney == value)
				{
					return;
				}
				_paymentMoney = value;
				PropertySet(this);
			}
		}

		public PaymentBluelinePart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

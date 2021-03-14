using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PaymentConditionTypeBase : BluelineConditionTypeBase
	{
		private CBool _inverted;
		private CBool _payWhenSucceded;

		[Ordinal(0)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get
			{
				if (_inverted == null)
				{
					_inverted = (CBool) CR2WTypeManager.Create("Bool", "inverted", cr2w, this);
				}
				return _inverted;
			}
			set
			{
				if (_inverted == value)
				{
					return;
				}
				_inverted = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("payWhenSucceded")] 
		public CBool PayWhenSucceded
		{
			get
			{
				if (_payWhenSucceded == null)
				{
					_payWhenSucceded = (CBool) CR2WTypeManager.Create("Bool", "payWhenSucceded", cr2w, this);
				}
				return _payWhenSucceded;
			}
			set
			{
				if (_payWhenSucceded == value)
				{
					return;
				}
				_payWhenSucceded = value;
				PropertySet(this);
			}
		}

		public PaymentConditionTypeBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

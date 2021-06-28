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
			get => GetProperty(ref _inverted);
			set => SetProperty(ref _inverted, value);
		}

		[Ordinal(1)] 
		[RED("payWhenSucceded")] 
		public CBool PayWhenSucceded
		{
			get => GetProperty(ref _payWhenSucceded);
			set => SetProperty(ref _payWhenSucceded, value);
		}

		public PaymentConditionTypeBase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

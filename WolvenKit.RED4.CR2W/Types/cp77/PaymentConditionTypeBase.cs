using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PaymentConditionTypeBase : BluelineConditionTypeBase
	{
		[Ordinal(0)] [RED("inverted")] public CBool Inverted { get; set; }
		[Ordinal(1)] [RED("payWhenSucceded")] public CBool PayWhenSucceded { get; set; }

		public PaymentConditionTypeBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

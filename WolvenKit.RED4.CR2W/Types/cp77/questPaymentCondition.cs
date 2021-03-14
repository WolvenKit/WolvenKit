using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPaymentCondition : questTypedCondition
	{
		private CHandle<questIPayment_ConditionType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questIPayment_ConditionType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CHandle<questIPayment_ConditionType>) CR2WTypeManager.Create("handle:questIPayment_ConditionType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		public questPaymentCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

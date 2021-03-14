using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpBumpEvent : redEvent
	{
		private CUInt32 _amount;

		[Ordinal(0)] 
		[RED("amount")] 
		public CUInt32 Amount
		{
			get
			{
				if (_amount == null)
				{
					_amount = (CUInt32) CR2WTypeManager.Create("Uint32", "amount", cr2w, this);
				}
				return _amount;
			}
			set
			{
				if (_amount == value)
				{
					return;
				}
				_amount = value;
				PropertySet(this);
			}
		}

		public cpBumpEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

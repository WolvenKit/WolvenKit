using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class megatronChargeController : ChargeLogicController
	{
		private wCHandle<inkImageWidget> _chargeBar;

		[Ordinal(1)] 
		[RED("chargeBar")] 
		public wCHandle<inkImageWidget> ChargeBar
		{
			get
			{
				if (_chargeBar == null)
				{
					_chargeBar = (wCHandle<inkImageWidget>) CR2WTypeManager.Create("whandle:inkImageWidget", "chargeBar", cr2w, this);
				}
				return _chargeBar;
			}
			set
			{
				if (_chargeBar == value)
				{
					return;
				}
				_chargeBar = value;
				PropertySet(this);
			}
		}

		public megatronChargeController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

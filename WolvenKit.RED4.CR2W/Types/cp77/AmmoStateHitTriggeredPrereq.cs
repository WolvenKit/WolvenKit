using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AmmoStateHitTriggeredPrereq : HitTriggeredPrereq
	{
		private CEnum<EMagazineAmmoState> _valueToListen;

		[Ordinal(5)] 
		[RED("valueToListen")] 
		public CEnum<EMagazineAmmoState> ValueToListen
		{
			get
			{
				if (_valueToListen == null)
				{
					_valueToListen = (CEnum<EMagazineAmmoState>) CR2WTypeManager.Create("EMagazineAmmoState", "valueToListen", cr2w, this);
				}
				return _valueToListen;
			}
			set
			{
				if (_valueToListen == value)
				{
					return;
				}
				_valueToListen = value;
				PropertySet(this);
			}
		}

		public AmmoStateHitTriggeredPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

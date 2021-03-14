using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAppearanceStatusEvent : redEvent
	{
		private CEnum<entAppearanceStatus> _status;

		[Ordinal(0)] 
		[RED("status")] 
		public CEnum<entAppearanceStatus> Status
		{
			get
			{
				if (_status == null)
				{
					_status = (CEnum<entAppearanceStatus>) CR2WTypeManager.Create("entAppearanceStatus", "status", cr2w, this);
				}
				return _status;
			}
			set
			{
				if (_status == value)
				{
					return;
				}
				_status = value;
				PropertySet(this);
			}
		}

		public entAppearanceStatusEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

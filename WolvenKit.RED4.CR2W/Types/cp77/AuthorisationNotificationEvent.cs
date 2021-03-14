using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AuthorisationNotificationEvent : redEvent
	{
		private CEnum<gameuiAuthorisationNotificationType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gameuiAuthorisationNotificationType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gameuiAuthorisationNotificationType>) CR2WTypeManager.Create("gameuiAuthorisationNotificationType", "type", cr2w, this);
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

		public AuthorisationNotificationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiAuthorisationNotificationViewData : gameuiGenericNotificationViewData
	{
		private CEnum<gameuiAuthorisationNotificationType> _authType;

		[Ordinal(5)] 
		[RED("authType")] 
		public CEnum<gameuiAuthorisationNotificationType> AuthType
		{
			get
			{
				if (_authType == null)
				{
					_authType = (CEnum<gameuiAuthorisationNotificationType>) CR2WTypeManager.Create("gameuiAuthorisationNotificationType", "authType", cr2w, this);
				}
				return _authType;
			}
			set
			{
				if (_authType == value)
				{
					return;
				}
				_authType = value;
				PropertySet(this);
			}
		}

		public gameuiAuthorisationNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

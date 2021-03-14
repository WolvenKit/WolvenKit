using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIMenuNotificationEvent : redEvent
	{
		private CEnum<UIMenuNotificationType> _notificationType;
		private CVariant _additionalInfo;

		[Ordinal(0)] 
		[RED("notificationType")] 
		public CEnum<UIMenuNotificationType> NotificationType
		{
			get
			{
				if (_notificationType == null)
				{
					_notificationType = (CEnum<UIMenuNotificationType>) CR2WTypeManager.Create("UIMenuNotificationType", "notificationType", cr2w, this);
				}
				return _notificationType;
			}
			set
			{
				if (_notificationType == value)
				{
					return;
				}
				_notificationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("additionalInfo")] 
		public CVariant AdditionalInfo
		{
			get
			{
				if (_additionalInfo == null)
				{
					_additionalInfo = (CVariant) CR2WTypeManager.Create("Variant", "additionalInfo", cr2w, this);
				}
				return _additionalInfo;
			}
			set
			{
				if (_additionalInfo == value)
				{
					return;
				}
				_additionalInfo = value;
				PropertySet(this);
			}
		}

		public UIMenuNotificationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

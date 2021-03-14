using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CraftingNotificationEvent : redEvent
	{
		private CEnum<CraftingNotificationType> _notificationType;
		private CString _perkName;

		[Ordinal(0)] 
		[RED("notificationType")] 
		public CEnum<CraftingNotificationType> NotificationType
		{
			get
			{
				if (_notificationType == null)
				{
					_notificationType = (CEnum<CraftingNotificationType>) CR2WTypeManager.Create("CraftingNotificationType", "notificationType", cr2w, this);
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
		[RED("perkName")] 
		public CString PerkName
		{
			get
			{
				if (_perkName == null)
				{
					_perkName = (CString) CR2WTypeManager.Create("String", "perkName", cr2w, this);
				}
				return _perkName;
			}
			set
			{
				if (_perkName == value)
				{
					return;
				}
				_perkName = value;
				PropertySet(this);
			}
		}

		public CraftingNotificationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

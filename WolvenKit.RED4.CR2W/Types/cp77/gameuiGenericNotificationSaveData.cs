using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiGenericNotificationSaveData : gameuiBaseUIData
	{
		private CArray<gameuiGenericNotificationData> _notificationsData;

		[Ordinal(1)] 
		[RED("notificationsData")] 
		public CArray<gameuiGenericNotificationData> NotificationsData
		{
			get
			{
				if (_notificationsData == null)
				{
					_notificationsData = (CArray<gameuiGenericNotificationData>) CR2WTypeManager.Create("array:gameuiGenericNotificationData", "notificationsData", cr2w, this);
				}
				return _notificationsData;
			}
			set
			{
				if (_notificationsData == value)
				{
					return;
				}
				_notificationsData = value;
				PropertySet(this);
			}
		}

		public gameuiGenericNotificationSaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

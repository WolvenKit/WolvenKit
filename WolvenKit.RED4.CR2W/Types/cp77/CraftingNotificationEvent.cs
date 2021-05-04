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
			get => GetProperty(ref _notificationType);
			set => SetProperty(ref _notificationType, value);
		}

		[Ordinal(1)] 
		[RED("perkName")] 
		public CString PerkName
		{
			get => GetProperty(ref _perkName);
			set => SetProperty(ref _perkName, value);
		}

		public CraftingNotificationEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

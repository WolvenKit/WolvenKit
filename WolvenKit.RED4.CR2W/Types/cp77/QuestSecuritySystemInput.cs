using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestSecuritySystemInput : redEvent
	{
		private CEnum<SecurityEventScopeSettings> _notificationScope;
		private CArray<NPCReference> _notifySpecificNPCs;
		private RevealPlayerSettings _revealPlayerSettings;

		[Ordinal(0)] 
		[RED("notificationScope")] 
		public CEnum<SecurityEventScopeSettings> NotificationScope
		{
			get => GetProperty(ref _notificationScope);
			set => SetProperty(ref _notificationScope, value);
		}

		[Ordinal(1)] 
		[RED("notifySpecificNPCs")] 
		public CArray<NPCReference> NotifySpecificNPCs
		{
			get => GetProperty(ref _notifySpecificNPCs);
			set => SetProperty(ref _notifySpecificNPCs, value);
		}

		[Ordinal(2)] 
		[RED("revealPlayerSettings")] 
		public RevealPlayerSettings RevealPlayerSettings
		{
			get => GetProperty(ref _revealPlayerSettings);
			set => SetProperty(ref _revealPlayerSettings, value);
		}

		public QuestSecuritySystemInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

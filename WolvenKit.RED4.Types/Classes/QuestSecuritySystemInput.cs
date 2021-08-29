using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestSecuritySystemInput : redEvent
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
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestSecuritySystemInput : redEvent
	{
		[Ordinal(0)] 
		[RED("notificationScope")] 
		public CEnum<SecurityEventScopeSettings> NotificationScope
		{
			get => GetPropertyValue<CEnum<SecurityEventScopeSettings>>();
			set => SetPropertyValue<CEnum<SecurityEventScopeSettings>>(value);
		}

		[Ordinal(1)] 
		[RED("notifySpecificNPCs")] 
		public CArray<NPCReference> NotifySpecificNPCs
		{
			get => GetPropertyValue<CArray<NPCReference>>();
			set => SetPropertyValue<CArray<NPCReference>>(value);
		}

		[Ordinal(2)] 
		[RED("revealPlayerSettings")] 
		public RevealPlayerSettings RevealPlayerSettings
		{
			get => GetPropertyValue<RevealPlayerSettings>();
			set => SetPropertyValue<RevealPlayerSettings>(value);
		}

		public QuestSecuritySystemInput()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

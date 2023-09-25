using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NPCKillDataTrackingRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("eventType")] 
		public CEnum<EDownedType> EventType
		{
			get => GetPropertyValue<CEnum<EDownedType>>();
			set => SetPropertyValue<CEnum<EDownedType>>(value);
		}

		[Ordinal(2)] 
		[RED("damageEntry")] 
		public DamageHistoryEntry DamageEntry
		{
			get => GetPropertyValue<DamageHistoryEntry>();
			set => SetPropertyValue<DamageHistoryEntry>(value);
		}

		[Ordinal(3)] 
		[RED("isDownedRecorded")] 
		public CBool IsDownedRecorded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NPCKillDataTrackingRequest()
		{
			DamageEntry = new DamageHistoryEntry();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

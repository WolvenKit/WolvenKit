using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WorldMapTooltipData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("controller")] 
		public CWeakHandle<gameuiBaseWorldMapMappinController> Controller
		{
			get => GetPropertyValue<CWeakHandle<gameuiBaseWorldMapMappinController>>();
			set => SetPropertyValue<CWeakHandle<gameuiBaseWorldMapMappinController>>(value);
		}

		[Ordinal(1)] 
		[RED("mappin")] 
		public CWeakHandle<gamemappinsIMappin> Mappin
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsIMappin>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsIMappin>>(value);
		}

		[Ordinal(2)] 
		[RED("journalEntry")] 
		public CWeakHandle<gameJournalEntry> JournalEntry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalEntry>>();
			set => SetPropertyValue<CWeakHandle<gameJournalEntry>>(value);
		}

		[Ordinal(3)] 
		[RED("fastTravelEnabled")] 
		public CBool FastTravelEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("delamainTaxiEnabled")] 
		public CBool DelamainTaxiEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("travelCost")] 
		public CInt32 TravelCost
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("playerMoney")] 
		public CInt32 PlayerMoney
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("readJournal")] 
		public CBool ReadJournal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("moreInfo")] 
		public CBool MoreInfo
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("isCollection")] 
		public CBool IsCollection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public WorldMapTooltipData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

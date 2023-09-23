using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerNPCBodyGameController : BaseChunkGameController
	{
		[Ordinal(5)] 
		[RED("factionText")] 
		public inkTextWidgetReference FactionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("dataBaseWidgetHolder")] 
		public inkWidgetReference DataBaseWidgetHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("factionCallbackID")] 
		public CHandle<redCallbackObject> FactionCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(8)] 
		[RED("rarityCallbackID")] 
		public CHandle<redCallbackObject> RarityCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(9)] 
		[RED("isValidFaction")] 
		public CBool IsValidFaction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("asyncSpawnRequest")] 
		public CWeakHandle<inkAsyncSpawnRequest> AsyncSpawnRequest
		{
			get => GetPropertyValue<CWeakHandle<inkAsyncSpawnRequest>>();
			set => SetPropertyValue<CWeakHandle<inkAsyncSpawnRequest>>(value);
		}

		public ScannerNPCBodyGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ConsumableChargesPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<PlayerPuppet> Owner
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(1)] 
		[RED("statPoolListener")] 
		public CHandle<ConsumableChargesPrereqListener> StatPoolListener
		{
			get => GetPropertyValue<CHandle<ConsumableChargesPrereqListener>>();
			set => SetPropertyValue<CHandle<ConsumableChargesPrereqListener>>(value);
		}

		[Ordinal(2)] 
		[RED("object")] 
		public CWeakHandle<gameObject> Object
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(3)] 
		[RED("statsObjID")] 
		public gameStatsObjectID StatsObjID
		{
			get => GetPropertyValue<gameStatsObjectID>();
			set => SetPropertyValue<gameStatsObjectID>(value);
		}

		public ConsumableChargesPrereqState()
		{
			StatsObjID = new gameStatsObjectID { IdType = Enums.gameStatIDType.Invalid };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

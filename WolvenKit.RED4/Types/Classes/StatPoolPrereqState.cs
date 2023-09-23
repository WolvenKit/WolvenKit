using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatPoolPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("statPoolListener")] 
		public CHandle<BaseStatPoolPrereqListener> StatPoolListener
		{
			get => GetPropertyValue<CHandle<BaseStatPoolPrereqListener>>();
			set => SetPropertyValue<CHandle<BaseStatPoolPrereqListener>>(value);
		}

		[Ordinal(1)] 
		[RED("statpoolWasMissing")] 
		public CBool StatpoolWasMissing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
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

		public StatPoolPrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatPoolBasedTimeBankEffector : gameContinuousEffector
	{
		[Ordinal(0)] 
		[RED("TimeBankValue")] 
		public CFloat TimeBankValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("maxStatPoolValue")] 
		public CFloat MaxStatPoolValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}

		[Ordinal(3)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(4)] 
		[RED("statPoolSystem")] 
		public CHandle<gameStatPoolsSystem> StatPoolSystem
		{
			get => GetPropertyValue<CHandle<gameStatPoolsSystem>>();
			set => SetPropertyValue<CHandle<gameStatPoolsSystem>>(value);
		}

		[Ordinal(5)] 
		[RED("TimeBankListener")] 
		public CHandle<TimeBankValueListener> TimeBankListener
		{
			get => GetPropertyValue<CHandle<TimeBankValueListener>>();
			set => SetPropertyValue<CHandle<TimeBankValueListener>>(value);
		}

		[Ordinal(6)] 
		[RED("StatPoolListener")] 
		public CHandle<StatPoolValueListener> StatPoolListener
		{
			get => GetPropertyValue<CHandle<StatPoolValueListener>>();
			set => SetPropertyValue<CHandle<StatPoolValueListener>>(value);
		}

		[Ordinal(7)] 
		[RED("playerEntityID")] 
		public entEntityID PlayerEntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(8)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(9)] 
		[RED("regenMod")] 
		public gameStatPoolModifier RegenMod
		{
			get => GetPropertyValue<gameStatPoolModifier>();
			set => SetPropertyValue<gameStatPoolModifier>(value);
		}

		public StatPoolBasedTimeBankEffector()
		{
			PlayerEntityID = new entEntityID();
			GameInstance = new ScriptGameInstance();
			RegenMod = new gameStatPoolModifier();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

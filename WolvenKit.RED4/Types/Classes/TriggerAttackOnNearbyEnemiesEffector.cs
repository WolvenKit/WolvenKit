using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TriggerAttackOnNearbyEnemiesEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("attackRecord")] 
		public CWeakHandle<gamedataAttack_Record> AttackRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataAttack_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAttack_Record>>(value);
		}

		[Ordinal(2)] 
		[RED("targetHowManyEnemies")] 
		public CInt32 TargetHowManyEnemies
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("targetMaxDistance")] 
		public CFloat TargetMaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("targetMinDistance")] 
		public CFloat TargetMinDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("ignoreCivilians")] 
		public CBool IgnoreCivilians
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(7)] 
		[RED("playVFXOnHitTargets")] 
		public CName PlayVFXOnHitTargets
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("statusEffectRecord")] 
		public CWeakHandle<gamedataStatusEffect_Record> StatusEffectRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataStatusEffect_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataStatusEffect_Record>>(value);
		}

		[Ordinal(9)] 
		[RED("enemySlotTransform")] 
		public CName EnemySlotTransform
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public TriggerAttackOnNearbyEnemiesEffector()
		{
			GameInstance = new ScriptGameInstance();
			EnemySlotTransform = "Chest";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

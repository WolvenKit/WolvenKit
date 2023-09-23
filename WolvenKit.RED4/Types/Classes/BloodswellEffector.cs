using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BloodswellEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("deathListener")] 
		public CHandle<BloodswellEffectorHealthListener> DeathListener
		{
			get => GetPropertyValue<CHandle<BloodswellEffectorHealthListener>>();
			set => SetPropertyValue<CHandle<BloodswellEffectorHealthListener>>(value);
		}

		[Ordinal(1)] 
		[RED("coldBloodListener")] 
		public CHandle<BloodswellEffectorColdBloodListener> ColdBloodListener
		{
			get => GetPropertyValue<CHandle<BloodswellEffectorColdBloodListener>>();
			set => SetPropertyValue<CHandle<BloodswellEffectorColdBloodListener>>(value);
		}

		[Ordinal(2)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(3)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(4)] 
		[RED("isImmortal")] 
		public CBool IsImmortal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public BloodswellEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ReflexesMasterPerk1Effector : ModifyAttackEffector
	{
		[Ordinal(0)] 
		[RED("operationType")] 
		public CEnum<EMathOperator> OperationType
		{
			get => GetPropertyValue<CEnum<EMathOperator>>();
			set => SetPropertyValue<CEnum<EMathOperator>>(value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("timeOut")] 
		public CFloat TimeOut
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("damageHistory")] 
		public CArray<CHandle<gameeventsHitEvent>> DamageHistory
		{
			get => GetPropertyValue<CArray<CHandle<gameeventsHitEvent>>>();
			set => SetPropertyValue<CArray<CHandle<gameeventsHitEvent>>>(value);
		}

		[Ordinal(4)] 
		[RED("listener")] 
		public CHandle<ReflexesMasterPerk1EffectorListener> Listener
		{
			get => GetPropertyValue<CHandle<ReflexesMasterPerk1EffectorListener>>();
			set => SetPropertyValue<CHandle<ReflexesMasterPerk1EffectorListener>>(value);
		}

		[Ordinal(5)] 
		[RED("lastTargetID")] 
		public entEntityID LastTargetID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public ReflexesMasterPerk1Effector()
		{
			DamageHistory = new();
			LastTargetID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

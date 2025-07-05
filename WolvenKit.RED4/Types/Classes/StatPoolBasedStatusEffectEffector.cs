using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatPoolBasedStatusEffectEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("statPool")] 
		public CEnum<gamedataStatPoolType> StatPool
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}

		[Ordinal(1)] 
		[RED("statusEffectID")] 
		public TweakDBID StatusEffectID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("statPoolStep")] 
		public CFloat StatPoolStep
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("stepUsesPercent")] 
		public CBool StepUsesPercent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("startingThreshold")] 
		public CFloat StartingThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("thresholdUsesPercent")] 
		public CBool ThresholdUsesPercent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("minStacks")] 
		public CInt32 MinStacks
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("maxStacks")] 
		public CInt32 MaxStacks
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("roundUpwards")] 
		public CBool RoundUpwards
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("dontRemoveStacks")] 
		public CBool DontRemoveStacks
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("targetOfStatPoolCheck")] 
		public CString TargetOfStatPoolCheck
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(12)] 
		[RED("listener")] 
		public CHandle<StatPoolBasedStatusEffectEffectorListener> Listener
		{
			get => GetPropertyValue<CHandle<StatPoolBasedStatusEffectEffectorListener>>();
			set => SetPropertyValue<CHandle<StatPoolBasedStatusEffectEffectorListener>>(value);
		}

		[Ordinal(13)] 
		[RED("currentStacks")] 
		public CInt32 CurrentStacks
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(14)] 
		[RED("realMaxStacks")] 
		public CInt32 RealMaxStacks
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(15)] 
		[RED("statPoolRecordID")] 
		public TweakDBID StatPoolRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(16)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(17)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(18)] 
		[RED("checkStatPoolOnWeapon")] 
		public CBool CheckStatPoolOnWeapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("ownerWeaponID")] 
		public entEntityID OwnerWeaponID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public StatPoolBasedStatusEffectEffector()
		{
			GameInstance = new ScriptGameInstance();
			OwnerID = new entEntityID();
			OwnerWeaponID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

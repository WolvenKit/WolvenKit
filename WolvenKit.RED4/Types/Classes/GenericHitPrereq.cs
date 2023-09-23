using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GenericHitPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("isSync")] 
		public CBool IsSync
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("processMiss")] 
		public CBool ProcessMiss
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("callbackType")] 
		public CEnum<gameDamageCallbackType> CallbackType
		{
			get => GetPropertyValue<CEnum<gameDamageCallbackType>>();
			set => SetPropertyValue<CEnum<gameDamageCallbackType>>(value);
		}

		[Ordinal(3)] 
		[RED("pipelineStage")] 
		public CEnum<gameDamagePipelineStage> PipelineStage
		{
			get => GetPropertyValue<CEnum<gameDamagePipelineStage>>();
			set => SetPropertyValue<CEnum<gameDamagePipelineStage>>(value);
		}

		[Ordinal(4)] 
		[RED("pipelineType")] 
		public CEnum<gameDamageListenerPipelineType> PipelineType
		{
			get => GetPropertyValue<CEnum<gameDamageListenerPipelineType>>();
			set => SetPropertyValue<CEnum<gameDamageListenerPipelineType>>(value);
		}

		[Ordinal(5)] 
		[RED("attackType")] 
		public CEnum<gamedataAttackType> AttackType
		{
			get => GetPropertyValue<CEnum<gamedataAttackType>>();
			set => SetPropertyValue<CEnum<gamedataAttackType>>(value);
		}

		[Ordinal(6)] 
		[RED("conditions")] 
		public CArray<CHandle<BaseHitPrereqCondition>> Conditions
		{
			get => GetPropertyValue<CArray<CHandle<BaseHitPrereqCondition>>>();
			set => SetPropertyValue<CArray<CHandle<BaseHitPrereqCondition>>>(value);
		}

		[Ordinal(7)] 
		[RED("ignoreSelfInflictedPressureWave")] 
		public CBool IgnoreSelfInflictedPressureWave
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public GenericHitPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

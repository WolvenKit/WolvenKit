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
		[RED("callbackType")] 
		public CEnum<gameDamageCallbackType> CallbackType
		{
			get => GetPropertyValue<CEnum<gameDamageCallbackType>>();
			set => SetPropertyValue<CEnum<gameDamageCallbackType>>(value);
		}

		[Ordinal(2)] 
		[RED("pipelineStage")] 
		public CEnum<gameDamagePipelineStage> PipelineStage
		{
			get => GetPropertyValue<CEnum<gameDamagePipelineStage>>();
			set => SetPropertyValue<CEnum<gameDamagePipelineStage>>(value);
		}

		[Ordinal(3)] 
		[RED("attackType")] 
		public CEnum<gamedataAttackType> AttackType
		{
			get => GetPropertyValue<CEnum<gamedataAttackType>>();
			set => SetPropertyValue<CEnum<gamedataAttackType>>(value);
		}

		[Ordinal(4)] 
		[RED("conditions")] 
		public CArray<CHandle<BaseHitPrereqCondition>> Conditions
		{
			get => GetPropertyValue<CArray<CHandle<BaseHitPrereqCondition>>>();
			set => SetPropertyValue<CArray<CHandle<BaseHitPrereqCondition>>>(value);
		}

		public GenericHitPrereq()
		{
			Conditions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

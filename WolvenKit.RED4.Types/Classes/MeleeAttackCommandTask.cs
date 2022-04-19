using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MeleeAttackCommandTask : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("inCommand")] 
		public CHandle<AIArgumentMapping> InCommand
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(1)] 
		[RED("currentCommand")] 
		public CWeakHandle<AIMeleeAttackCommand> CurrentCommand
		{
			get => GetPropertyValue<CWeakHandle<AIMeleeAttackCommand>>();
			set => SetPropertyValue<CWeakHandle<AIMeleeAttackCommand>>(value);
		}

		[Ordinal(2)] 
		[RED("threatPersistenceSource")] 
		public CHandle<gamedataAIThreatPersistenceSource_Record> ThreatPersistenceSource
		{
			get => GetPropertyValue<CHandle<gamedataAIThreatPersistenceSource_Record>>();
			set => SetPropertyValue<CHandle<gamedataAIThreatPersistenceSource_Record>>(value);
		}

		[Ordinal(3)] 
		[RED("activationTimeStamp")] 
		public CFloat ActivationTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("commandDuration")] 
		public CFloat CommandDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public MeleeAttackCommandTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

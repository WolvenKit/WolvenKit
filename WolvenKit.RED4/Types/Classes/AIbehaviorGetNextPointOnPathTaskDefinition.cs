using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorGetNextPointOnPathTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("patrolProgress")] 
		public CHandle<AIArgumentMapping> PatrolProgress
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("positionOnPath")] 
		public CHandle<AIArgumentMapping> PositionOnPath
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("entryTangent")] 
		public CHandle<AIArgumentMapping> EntryTangent
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorGetNextPointOnPathTaskDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

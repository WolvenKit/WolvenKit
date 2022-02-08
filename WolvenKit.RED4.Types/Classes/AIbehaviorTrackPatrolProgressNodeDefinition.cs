using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorTrackPatrolProgressNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(1)] 
		[RED("pathParameters")] 
		public CHandle<AIArgumentMapping> PathParameters
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("patrolProgress")] 
		public CHandle<AIArgumentMapping> PatrolProgress
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("startFromClosestPoint")] 
		public CHandle<AIArgumentMapping> StartFromClosestPoint
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}

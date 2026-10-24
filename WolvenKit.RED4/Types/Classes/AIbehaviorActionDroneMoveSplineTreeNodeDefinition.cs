using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorActionDroneMoveSplineTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(1)] 
		[RED("spline")] 
		public CHandle<AIArgumentMapping> Spline
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorActionDroneMoveSplineTreeNodeDefinition()
		{
			Command = new AIArgumentMapping { Type = Enums.AIArgumentType.Serializable, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "handle:ISerializable" };
			Spline = new AIArgumentMapping { Type = Enums.AIArgumentType.NodeRef, ParameterizationType = Enums.AIParameterizationType.CustomValue, DefaultValue = new CVariant(), CustomTypeName = "NodeRef" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

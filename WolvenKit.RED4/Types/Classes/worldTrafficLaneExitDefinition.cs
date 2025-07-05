using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficLaneExitDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("outLaneRef")] 
		public NodeRef OutLaneRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("exitPosition")] 
		public Vector4 ExitPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("exitProbability")] 
		public CFloat ExitProbability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("endConnection")] 
		public CBool EndConnection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("thisLaneReversed")] 
		public CBool ThisLaneReversed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("outLaneReversed")] 
		public CBool OutLaneReversed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldTrafficLaneExitDefinition()
		{
			ExitPosition = new Vector4 { W = 1.000000F };
			ExitProbability = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

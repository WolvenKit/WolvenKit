using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FloatMathOp : animAnimNode_FloatValue
	{
		[Ordinal(1)] 
		[RED("operationType")] 
		public CEnum<animEAnimGraphMathOp> OperationType
		{
			get => GetPropertyValue<CEnum<animEAnimGraphMathOp>>();
			set => SetPropertyValue<CEnum<animEAnimGraphMathOp>>(value);
		}

		[Ordinal(2)] 
		[RED("firstInputNode")] 
		public animFloatLink FirstInputNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(3)] 
		[RED("secondInputNode")] 
		public animFloatLink SecondInputNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_FloatMathOp()
		{
			Id = uint.MaxValue;
			OperationType = Enums.animEAnimGraphMathOp.AGMO_Abs;
			FirstInputNode = new animFloatLink();
			SecondInputNode = new animFloatLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

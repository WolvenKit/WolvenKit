using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_FloatMathOp : animAnimNode_FloatValue
	{
		[Ordinal(11)] 
		[RED("operationType")] 
		public CEnum<animEAnimGraphMathOp> OperationType
		{
			get => GetPropertyValue<CEnum<animEAnimGraphMathOp>>();
			set => SetPropertyValue<CEnum<animEAnimGraphMathOp>>(value);
		}

		[Ordinal(12)] 
		[RED("firstInputNode")] 
		public animFloatLink FirstInputNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(13)] 
		[RED("secondInputNode")] 
		public animFloatLink SecondInputNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_FloatMathOp()
		{
			Id = 4294967295;
			OperationType = Enums.animEAnimGraphMathOp.AGMO_Abs;
			FirstInputNode = new();
			SecondInputNode = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

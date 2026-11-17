using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_WrapperValue : animAnimNode_FloatValue
	{
		[Ordinal(1)] 
		[RED("wrapperNames")] 
		public CArray<CName> WrapperNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("logicOp")] 
		public CEnum<animEAnimGraphLogicOp> LogicOp
		{
			get => GetPropertyValue<CEnum<animEAnimGraphLogicOp>>();
			set => SetPropertyValue<CEnum<animEAnimGraphLogicOp>>(value);
		}

		[Ordinal(3)] 
		[RED("oneMinus")] 
		public CBool OneMinus
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimNode_WrapperValue()
		{
			Id = uint.MaxValue;
			WrapperNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

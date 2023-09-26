using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ConvertDamageToStatPoolEffector : HitEventEffector
	{
		[Ordinal(0)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}

		[Ordinal(1)] 
		[RED("operationType")] 
		public CEnum<EMathOperator> OperationType
		{
			get => GetPropertyValue<CEnum<EMathOperator>>();
			set => SetPropertyValue<CEnum<EMathOperator>>(value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ConvertDamageToStatPoolEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

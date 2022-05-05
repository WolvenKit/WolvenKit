using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModifyDamageEffector : ModifyAttackEffector
	{
		[Ordinal(0)] 
		[RED("operationType")] 
		public CEnum<EMathOperator> OperationType
		{
			get => GetPropertyValue<CEnum<EMathOperator>>();
			set => SetPropertyValue<CEnum<EMathOperator>>(value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ModifyDamageEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

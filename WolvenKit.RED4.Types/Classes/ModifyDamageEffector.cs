using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ModifyDamageEffector : ModifyAttackEffector
	{
		private CEnum<EMathOperator> _operationType;
		private CFloat _value;

		[Ordinal(0)] 
		[RED("operationType")] 
		public CEnum<EMathOperator> OperationType
		{
			get => GetProperty(ref _operationType);
			set => SetProperty(ref _operationType, value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questLogicalCondition : questCondition
	{
		private CEnum<questLogicalOperation> _operation;
		private CArray<CHandle<questIBaseCondition>> _conditions;

		[Ordinal(0)] 
		[RED("operation")] 
		public CEnum<questLogicalOperation> Operation
		{
			get => GetProperty(ref _operation);
			set => SetProperty(ref _operation, value);
		}

		[Ordinal(1)] 
		[RED("conditions")] 
		public CArray<CHandle<questIBaseCondition>> Conditions
		{
			get => GetProperty(ref _conditions);
			set => SetProperty(ref _conditions, value);
		}
	}
}

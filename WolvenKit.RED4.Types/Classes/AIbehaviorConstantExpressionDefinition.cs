using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorConstantExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		private AIbehaviorTypeRef _type;
		private CVariant _value;

		[Ordinal(0)] 
		[RED("type")] 
		public AIbehaviorTypeRef Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CVariant Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}
	}
}

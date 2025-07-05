using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questLogicalCondition : questCondition
	{
		[Ordinal(0)] 
		[RED("operation")] 
		public CEnum<questLogicalOperation> Operation
		{
			get => GetPropertyValue<CEnum<questLogicalOperation>>();
			set => SetPropertyValue<CEnum<questLogicalOperation>>(value);
		}

		[Ordinal(1)] 
		[RED("conditions")] 
		public CArray<CHandle<questIBaseCondition>> Conditions
		{
			get => GetPropertyValue<CArray<CHandle<questIBaseCondition>>>();
			set => SetPropertyValue<CArray<CHandle<questIBaseCondition>>>(value);
		}

		public questLogicalCondition()
		{
			Conditions = new() { null, null };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

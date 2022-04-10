using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnOverrideInterruptConditions_Operation : scnIInterruptManager_Operation
	{
		[Ordinal(0)] 
		[RED("interruptConditions")] 
		public CArray<CHandle<scnIInterruptCondition>> InterruptConditions
		{
			get => GetPropertyValue<CArray<CHandle<scnIInterruptCondition>>>();
			set => SetPropertyValue<CArray<CHandle<scnIInterruptCondition>>>(value);
		}

		public scnOverrideInterruptConditions_Operation()
		{
			InterruptConditions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

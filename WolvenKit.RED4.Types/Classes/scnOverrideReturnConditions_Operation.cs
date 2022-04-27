using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnOverrideReturnConditions_Operation : scnIInterruptManager_Operation
	{
		[Ordinal(0)] 
		[RED("returnConditions")] 
		public CArray<CHandle<scnIReturnCondition>> ReturnConditions
		{
			get => GetPropertyValue<CArray<CHandle<scnIReturnCondition>>>();
			set => SetPropertyValue<CArray<CHandle<scnIReturnCondition>>>(value);
		}

		public scnOverrideReturnConditions_Operation()
		{
			ReturnConditions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

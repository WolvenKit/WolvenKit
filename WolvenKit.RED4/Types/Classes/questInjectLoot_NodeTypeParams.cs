using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questInjectLoot_NodeTypeParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public CHandle<questUniversalRef> ObjectRef
		{
			get => GetPropertyValue<CHandle<questUniversalRef>>();
			set => SetPropertyValue<CHandle<questUniversalRef>>(value);
		}

		[Ordinal(1)] 
		[RED("operations")] 
		public CArray<questInjectLoot_NodeTypeParams_OperationData> Operations
		{
			get => GetPropertyValue<CArray<questInjectLoot_NodeTypeParams_OperationData>>();
			set => SetPropertyValue<CArray<questInjectLoot_NodeTypeParams_OperationData>>(value);
		}

		public questInjectLoot_NodeTypeParams()
		{
			Operations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

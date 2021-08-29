using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questInjectLoot_NodeTypeParams : RedBaseClass
	{
		private CHandle<questUniversalRef> _objectRef;
		private CArray<questInjectLoot_NodeTypeParams_OperationData> _operations;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public CHandle<questUniversalRef> ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("operations")] 
		public CArray<questInjectLoot_NodeTypeParams_OperationData> Operations
		{
			get => GetProperty(ref _operations);
			set => SetProperty(ref _operations, value);
		}
	}
}

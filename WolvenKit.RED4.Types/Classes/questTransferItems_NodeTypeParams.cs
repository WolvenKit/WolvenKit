using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questTransferItems_NodeTypeParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("giver")] 
		public CHandle<questUniversalRef> Giver
		{
			get => GetPropertyValue<CHandle<questUniversalRef>>();
			set => SetPropertyValue<CHandle<questUniversalRef>>(value);
		}

		[Ordinal(1)] 
		[RED("receiver")] 
		public CHandle<questUniversalRef> Receiver
		{
			get => GetPropertyValue<CHandle<questUniversalRef>>();
			set => SetPropertyValue<CHandle<questUniversalRef>>(value);
		}

		[Ordinal(2)] 
		[RED("transferAllOperation")] 
		public CHandle<questTransferItems_NodeTypeParams_TransferAllOperationData> TransferAllOperation
		{
			get => GetPropertyValue<CHandle<questTransferItems_NodeTypeParams_TransferAllOperationData>>();
			set => SetPropertyValue<CHandle<questTransferItems_NodeTypeParams_TransferAllOperationData>>(value);
		}

		[Ordinal(3)] 
		[RED("itemOperations")] 
		public CArray<questTransferItems_NodeTypeParams_OperationData> ItemOperations
		{
			get => GetPropertyValue<CArray<questTransferItems_NodeTypeParams_OperationData>>();
			set => SetPropertyValue<CArray<questTransferItems_NodeTypeParams_OperationData>>(value);
		}

		[Ordinal(4)] 
		[RED("tagOperations")] 
		public CArray<questTransferItems_NodeTypeParams_TagOperationData> TagOperations
		{
			get => GetPropertyValue<CArray<questTransferItems_NodeTypeParams_TagOperationData>>();
			set => SetPropertyValue<CArray<questTransferItems_NodeTypeParams_TagOperationData>>(value);
		}

		public questTransferItems_NodeTypeParams()
		{
			ItemOperations = new();
			TagOperations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

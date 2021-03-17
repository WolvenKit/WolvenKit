using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTransferItems_NodeTypeParams : CVariable
	{
		private CHandle<questUniversalRef> _giver;
		private CHandle<questUniversalRef> _receiver;
		private CHandle<questTransferItems_NodeTypeParams_TransferAllOperationData> _transferAllOperation;
		private CArray<questTransferItems_NodeTypeParams_OperationData> _itemOperations;
		private CArray<questTransferItems_NodeTypeParams_TagOperationData> _tagOperations;

		[Ordinal(0)] 
		[RED("giver")] 
		public CHandle<questUniversalRef> Giver
		{
			get => GetProperty(ref _giver);
			set => SetProperty(ref _giver, value);
		}

		[Ordinal(1)] 
		[RED("receiver")] 
		public CHandle<questUniversalRef> Receiver
		{
			get => GetProperty(ref _receiver);
			set => SetProperty(ref _receiver, value);
		}

		[Ordinal(2)] 
		[RED("transferAllOperation")] 
		public CHandle<questTransferItems_NodeTypeParams_TransferAllOperationData> TransferAllOperation
		{
			get => GetProperty(ref _transferAllOperation);
			set => SetProperty(ref _transferAllOperation, value);
		}

		[Ordinal(3)] 
		[RED("itemOperations")] 
		public CArray<questTransferItems_NodeTypeParams_OperationData> ItemOperations
		{
			get => GetProperty(ref _itemOperations);
			set => SetProperty(ref _itemOperations, value);
		}

		[Ordinal(4)] 
		[RED("tagOperations")] 
		public CArray<questTransferItems_NodeTypeParams_TagOperationData> TagOperations
		{
			get => GetProperty(ref _tagOperations);
			set => SetProperty(ref _tagOperations, value);
		}

		public questTransferItems_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

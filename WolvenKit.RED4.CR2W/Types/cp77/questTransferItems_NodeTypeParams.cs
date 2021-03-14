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
			get
			{
				if (_giver == null)
				{
					_giver = (CHandle<questUniversalRef>) CR2WTypeManager.Create("handle:questUniversalRef", "giver", cr2w, this);
				}
				return _giver;
			}
			set
			{
				if (_giver == value)
				{
					return;
				}
				_giver = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("receiver")] 
		public CHandle<questUniversalRef> Receiver
		{
			get
			{
				if (_receiver == null)
				{
					_receiver = (CHandle<questUniversalRef>) CR2WTypeManager.Create("handle:questUniversalRef", "receiver", cr2w, this);
				}
				return _receiver;
			}
			set
			{
				if (_receiver == value)
				{
					return;
				}
				_receiver = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("transferAllOperation")] 
		public CHandle<questTransferItems_NodeTypeParams_TransferAllOperationData> TransferAllOperation
		{
			get
			{
				if (_transferAllOperation == null)
				{
					_transferAllOperation = (CHandle<questTransferItems_NodeTypeParams_TransferAllOperationData>) CR2WTypeManager.Create("handle:questTransferItems_NodeTypeParams_TransferAllOperationData", "transferAllOperation", cr2w, this);
				}
				return _transferAllOperation;
			}
			set
			{
				if (_transferAllOperation == value)
				{
					return;
				}
				_transferAllOperation = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("itemOperations")] 
		public CArray<questTransferItems_NodeTypeParams_OperationData> ItemOperations
		{
			get
			{
				if (_itemOperations == null)
				{
					_itemOperations = (CArray<questTransferItems_NodeTypeParams_OperationData>) CR2WTypeManager.Create("array:questTransferItems_NodeTypeParams_OperationData", "itemOperations", cr2w, this);
				}
				return _itemOperations;
			}
			set
			{
				if (_itemOperations == value)
				{
					return;
				}
				_itemOperations = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("tagOperations")] 
		public CArray<questTransferItems_NodeTypeParams_TagOperationData> TagOperations
		{
			get
			{
				if (_tagOperations == null)
				{
					_tagOperations = (CArray<questTransferItems_NodeTypeParams_TagOperationData>) CR2WTypeManager.Create("array:questTransferItems_NodeTypeParams_TagOperationData", "tagOperations", cr2w, this);
				}
				return _tagOperations;
			}
			set
			{
				if (_tagOperations == value)
				{
					return;
				}
				_tagOperations = value;
				PropertySet(this);
			}
		}

		public questTransferItems_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

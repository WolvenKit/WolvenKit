using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAddRemoveItem_NodeTypeParams : ISerializable
	{
		private CBool _sendNotification;
		private CBool _isPlayer;
		private gameEntityReference _objectRef;
		private CHandle<questUniversalRef> _entityRef;
		private CEnum<questEAddRemoveItemType> _nodeType;
		private TweakDBID _itemID;
		private CInt32 _quantity;
		private CBool _flagItemAddedCallbackAsSilent;
		private CBool _removeAllQuantity;
		private CName _tagToRemove;
		private CArray<TweakDBID> _itemIDsToIgnoreOnRemove;
		private CArray<CName> _tagsToIgnoreOnRemove;

		[Ordinal(0)] 
		[RED("sendNotification")] 
		public CBool SendNotification
		{
			get => GetProperty(ref _sendNotification);
			set => SetProperty(ref _sendNotification, value);
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(2)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(3)] 
		[RED("entityRef")] 
		public CHandle<questUniversalRef> EntityRef
		{
			get => GetProperty(ref _entityRef);
			set => SetProperty(ref _entityRef, value);
		}

		[Ordinal(4)] 
		[RED("nodeType")] 
		public CEnum<questEAddRemoveItemType> NodeType
		{
			get => GetProperty(ref _nodeType);
			set => SetProperty(ref _nodeType, value);
		}

		[Ordinal(5)] 
		[RED("itemID")] 
		public TweakDBID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(6)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetProperty(ref _quantity);
			set => SetProperty(ref _quantity, value);
		}

		[Ordinal(7)] 
		[RED("flagItemAddedCallbackAsSilent")] 
		public CBool FlagItemAddedCallbackAsSilent
		{
			get => GetProperty(ref _flagItemAddedCallbackAsSilent);
			set => SetProperty(ref _flagItemAddedCallbackAsSilent, value);
		}

		[Ordinal(8)] 
		[RED("removeAllQuantity")] 
		public CBool RemoveAllQuantity
		{
			get => GetProperty(ref _removeAllQuantity);
			set => SetProperty(ref _removeAllQuantity, value);
		}

		[Ordinal(9)] 
		[RED("tagToRemove")] 
		public CName TagToRemove
		{
			get => GetProperty(ref _tagToRemove);
			set => SetProperty(ref _tagToRemove, value);
		}

		[Ordinal(10)] 
		[RED("itemIDsToIgnoreOnRemove")] 
		public CArray<TweakDBID> ItemIDsToIgnoreOnRemove
		{
			get => GetProperty(ref _itemIDsToIgnoreOnRemove);
			set => SetProperty(ref _itemIDsToIgnoreOnRemove, value);
		}

		[Ordinal(11)] 
		[RED("tagsToIgnoreOnRemove")] 
		public CArray<CName> TagsToIgnoreOnRemove
		{
			get => GetProperty(ref _tagsToIgnoreOnRemove);
			set => SetProperty(ref _tagsToIgnoreOnRemove, value);
		}

		public questAddRemoveItem_NodeTypeParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

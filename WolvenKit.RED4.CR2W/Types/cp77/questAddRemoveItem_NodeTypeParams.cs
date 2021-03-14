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
			get
			{
				if (_sendNotification == null)
				{
					_sendNotification = (CBool) CR2WTypeManager.Create("Bool", "sendNotification", cr2w, this);
				}
				return _sendNotification;
			}
			set
			{
				if (_sendNotification == value)
				{
					return;
				}
				_sendNotification = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get
			{
				if (_isPlayer == null)
				{
					_isPlayer = (CBool) CR2WTypeManager.Create("Bool", "isPlayer", cr2w, this);
				}
				return _isPlayer;
			}
			set
			{
				if (_isPlayer == value)
				{
					return;
				}
				_isPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "objectRef", cr2w, this);
				}
				return _objectRef;
			}
			set
			{
				if (_objectRef == value)
				{
					return;
				}
				_objectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("entityRef")] 
		public CHandle<questUniversalRef> EntityRef
		{
			get
			{
				if (_entityRef == null)
				{
					_entityRef = (CHandle<questUniversalRef>) CR2WTypeManager.Create("handle:questUniversalRef", "entityRef", cr2w, this);
				}
				return _entityRef;
			}
			set
			{
				if (_entityRef == value)
				{
					return;
				}
				_entityRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("nodeType")] 
		public CEnum<questEAddRemoveItemType> NodeType
		{
			get
			{
				if (_nodeType == null)
				{
					_nodeType = (CEnum<questEAddRemoveItemType>) CR2WTypeManager.Create("questEAddRemoveItemType", "nodeType", cr2w, this);
				}
				return _nodeType;
			}
			set
			{
				if (_nodeType == value)
				{
					return;
				}
				_nodeType = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("itemID")] 
		public TweakDBID ItemID
		{
			get
			{
				if (_itemID == null)
				{
					_itemID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "itemID", cr2w, this);
				}
				return _itemID;
			}
			set
			{
				if (_itemID == value)
				{
					return;
				}
				_itemID = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get
			{
				if (_quantity == null)
				{
					_quantity = (CInt32) CR2WTypeManager.Create("Int32", "quantity", cr2w, this);
				}
				return _quantity;
			}
			set
			{
				if (_quantity == value)
				{
					return;
				}
				_quantity = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("flagItemAddedCallbackAsSilent")] 
		public CBool FlagItemAddedCallbackAsSilent
		{
			get
			{
				if (_flagItemAddedCallbackAsSilent == null)
				{
					_flagItemAddedCallbackAsSilent = (CBool) CR2WTypeManager.Create("Bool", "flagItemAddedCallbackAsSilent", cr2w, this);
				}
				return _flagItemAddedCallbackAsSilent;
			}
			set
			{
				if (_flagItemAddedCallbackAsSilent == value)
				{
					return;
				}
				_flagItemAddedCallbackAsSilent = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("removeAllQuantity")] 
		public CBool RemoveAllQuantity
		{
			get
			{
				if (_removeAllQuantity == null)
				{
					_removeAllQuantity = (CBool) CR2WTypeManager.Create("Bool", "removeAllQuantity", cr2w, this);
				}
				return _removeAllQuantity;
			}
			set
			{
				if (_removeAllQuantity == value)
				{
					return;
				}
				_removeAllQuantity = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("tagToRemove")] 
		public CName TagToRemove
		{
			get
			{
				if (_tagToRemove == null)
				{
					_tagToRemove = (CName) CR2WTypeManager.Create("CName", "tagToRemove", cr2w, this);
				}
				return _tagToRemove;
			}
			set
			{
				if (_tagToRemove == value)
				{
					return;
				}
				_tagToRemove = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("itemIDsToIgnoreOnRemove")] 
		public CArray<TweakDBID> ItemIDsToIgnoreOnRemove
		{
			get
			{
				if (_itemIDsToIgnoreOnRemove == null)
				{
					_itemIDsToIgnoreOnRemove = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "itemIDsToIgnoreOnRemove", cr2w, this);
				}
				return _itemIDsToIgnoreOnRemove;
			}
			set
			{
				if (_itemIDsToIgnoreOnRemove == value)
				{
					return;
				}
				_itemIDsToIgnoreOnRemove = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("tagsToIgnoreOnRemove")] 
		public CArray<CName> TagsToIgnoreOnRemove
		{
			get
			{
				if (_tagsToIgnoreOnRemove == null)
				{
					_tagsToIgnoreOnRemove = (CArray<CName>) CR2WTypeManager.Create("array:CName", "tagsToIgnoreOnRemove", cr2w, this);
				}
				return _tagsToIgnoreOnRemove;
			}
			set
			{
				if (_tagsToIgnoreOnRemove == value)
				{
					return;
				}
				_tagsToIgnoreOnRemove = value;
				PropertySet(this);
			}
		}

		public questAddRemoveItem_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questAddRemoveItem_NodeTypeParams : ISerializable
	{
		[Ordinal(0)] 
		[RED("sendNotification")] 
		public CBool SendNotification
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(3)] 
		[RED("entityRef")] 
		public CHandle<questUniversalRef> EntityRef
		{
			get => GetPropertyValue<CHandle<questUniversalRef>>();
			set => SetPropertyValue<CHandle<questUniversalRef>>(value);
		}

		[Ordinal(4)] 
		[RED("nodeType")] 
		public CEnum<questEAddRemoveItemType> NodeType
		{
			get => GetPropertyValue<CEnum<questEAddRemoveItemType>>();
			set => SetPropertyValue<CEnum<questEAddRemoveItemType>>(value);
		}

		[Ordinal(5)] 
		[RED("itemID")] 
		public TweakDBID ItemID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(6)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("flagItemAddedCallbackAsSilent")] 
		public CBool FlagItemAddedCallbackAsSilent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("removeAllQuantity")] 
		public CBool RemoveAllQuantity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("tagToRemove")] 
		public CName TagToRemove
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("itemIDsToIgnoreOnRemove")] 
		public CArray<TweakDBID> ItemIDsToIgnoreOnRemove
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(11)] 
		[RED("tagsToIgnoreOnRemove")] 
		public CArray<CName> TagsToIgnoreOnRemove
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public questAddRemoveItem_NodeTypeParams()
		{
			ObjectRef = new gameEntityReference { Names = new() };
			Quantity = 1;
			ItemIDsToIgnoreOnRemove = new();
			TagsToIgnoreOnRemove = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

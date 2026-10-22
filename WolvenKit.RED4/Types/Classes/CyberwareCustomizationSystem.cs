using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberwareCustomizationSystem : gameCyberwareCustomizationSystem
	{
		[Ordinal(0)] 
		[RED("savedData")] 
		public CyberwareCustomizationPersistentData SavedData
		{
			get => GetPropertyValue<CyberwareCustomizationPersistentData>();
			set => SetPropertyValue<CyberwareCustomizationPersistentData>(value);
		}

		[Ordinal(1)] 
		[RED("transactionSystem")] 
		public CWeakHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetPropertyValue<CWeakHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CWeakHandle<gameTransactionSystem>>(value);
		}

		[Ordinal(2)] 
		[RED("attachmentSlotCallback")] 
		public CHandle<gameAttachmentSlotsScriptListener> AttachmentSlotCallback
		{
			get => GetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>();
			set => SetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>(value);
		}

		[Ordinal(3)] 
		[RED("playerAttachedCallbackID")] 
		public CUInt32 PlayerAttachedCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("playerPuppet")] 
		public CWeakHandle<gameObject> PlayerPuppet
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public CyberwareCustomizationSystem()
		{
			SavedData = new CyberwareCustomizationPersistentData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

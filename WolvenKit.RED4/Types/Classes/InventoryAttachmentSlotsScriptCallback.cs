using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryAttachmentSlotsScriptCallback : gameAttachmentSlotsScriptCallback
	{
		[Ordinal(2)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(3)] 
		[RED("transactionSystem")] 
		public CWeakHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetPropertyValue<CWeakHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CWeakHandle<gameTransactionSystem>>(value);
		}

		[Ordinal(4)] 
		[RED("controller")] 
		public CWeakHandle<gameuiInventoryGameController> Controller
		{
			get => GetPropertyValue<CWeakHandle<gameuiInventoryGameController>>();
			set => SetPropertyValue<CWeakHandle<gameuiInventoryGameController>>(value);
		}

		[Ordinal(5)] 
		[RED("isUnequipping")] 
		public CBool IsUnequipping
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("showDelay")] 
		public CFloat ShowDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("slotToWaitFor")] 
		public TweakDBID SlotToWaitFor
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public InventoryAttachmentSlotsScriptCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

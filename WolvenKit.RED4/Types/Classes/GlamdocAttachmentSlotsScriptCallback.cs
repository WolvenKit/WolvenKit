using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GlamdocAttachmentSlotsScriptCallback : gameAttachmentSlotsScriptCallback
	{
		[Ordinal(2)] 
		[RED("puppet")] 
		public CWeakHandle<gamePuppet> Puppet
		{
			get => GetPropertyValue<CWeakHandle<gamePuppet>>();
			set => SetPropertyValue<CWeakHandle<gamePuppet>>(value);
		}

		[Ordinal(3)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(4)] 
		[RED("transactionSystem")] 
		public CWeakHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetPropertyValue<CWeakHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CWeakHandle<gameTransactionSystem>>(value);
		}

		[Ordinal(5)] 
		[RED("slotToWaitFor")] 
		public TweakDBID SlotToWaitFor
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(6)] 
		[RED("slotToClear")] 
		public TweakDBID SlotToClear
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(7)] 
		[RED("itemToWaitFor")] 
		public gameItemID ItemToWaitFor
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(8)] 
		[RED("controller")] 
		public CWeakHandle<GlamDocGameController> Controller
		{
			get => GetPropertyValue<CWeakHandle<GlamDocGameController>>();
			set => SetPropertyValue<CWeakHandle<GlamDocGameController>>(value);
		}

		[Ordinal(9)] 
		[RED("visualSlots")] 
		public CArray<TweakDBID> VisualSlots
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(10)] 
		[RED("isUnequipping")] 
		public CBool IsUnequipping
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("timeToWaitWhenUnequipping")] 
		public CFloat TimeToWaitWhenUnequipping
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public GlamdocAttachmentSlotsScriptCallback()
		{
			ItemToWaitFor = new gameItemID();
			VisualSlots = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

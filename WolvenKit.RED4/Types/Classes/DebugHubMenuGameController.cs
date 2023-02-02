using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DebugHubMenuGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("menuCtrl")] 
		public CWeakHandle<DebugHubMenuLogicController> MenuCtrl
		{
			get => GetPropertyValue<CWeakHandle<DebugHubMenuLogicController>>();
			set => SetPropertyValue<CWeakHandle<DebugHubMenuLogicController>>(value);
		}

		[Ordinal(4)] 
		[RED("selectorCtrl")] 
		public CWeakHandle<hubSelectorController> SelectorCtrl
		{
			get => GetPropertyValue<CWeakHandle<hubSelectorController>>();
			set => SetPropertyValue<CWeakHandle<hubSelectorController>>(value);
		}

		[Ordinal(5)] 
		[RED("menuEventDispatcher")] 
		public CWeakHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>();
			set => SetPropertyValue<CWeakHandle<inkMenuEventDispatcher>>(value);
		}

		[Ordinal(6)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(7)] 
		[RED("PDS")] 
		public CHandle<PlayerDevelopmentSystem> PDS
		{
			get => GetPropertyValue<CHandle<PlayerDevelopmentSystem>>();
			set => SetPropertyValue<CHandle<PlayerDevelopmentSystem>>(value);
		}

		[Ordinal(8)] 
		[RED("currencyListener")] 
		public CUInt32 CurrencyListener
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(9)] 
		[RED("characterCredListener")] 
		public CUInt32 CharacterCredListener
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(10)] 
		[RED("characterLevelListener")] 
		public CUInt32 CharacterLevelListener
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(11)] 
		[RED("characterCurrentXPListener")] 
		public CUInt32 CharacterCurrentXPListener
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(12)] 
		[RED("characterCredPointsListener")] 
		public CUInt32 CharacterCredPointsListener
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(13)] 
		[RED("Transaction")] 
		public CHandle<gameTransactionSystem> Transaction
		{
			get => GetPropertyValue<CHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CHandle<gameTransactionSystem>>(value);
		}

		public DebugHubMenuGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

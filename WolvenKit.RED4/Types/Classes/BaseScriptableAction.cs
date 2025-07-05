using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class BaseScriptableAction : gamedeviceAction
	{
		[Ordinal(4)] 
		[RED("requesterID")] 
		public entEntityID RequesterID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(5)] 
		[RED("executor")] 
		public CWeakHandle<gameObject> Executor
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(6)] 
		[RED("proxyExecutor")] 
		public CWeakHandle<gameObject> ProxyExecutor
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(7)] 
		[RED("costComponents")] 
		public CArray<CWeakHandle<gamedataObjectActionCost_Record>> CostComponents
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataObjectActionCost_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataObjectActionCost_Record>>>(value);
		}

		[Ordinal(8)] 
		[RED("objectActionID")] 
		public TweakDBID ObjectActionID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(9)] 
		[RED("objectActionRecord")] 
		public CWeakHandle<gamedataObjectAction_Record> ObjectActionRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataObjectAction_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataObjectAction_Record>>(value);
		}

		[Ordinal(10)] 
		[RED("inkWidgetID")] 
		public TweakDBID InkWidgetID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(11)] 
		[RED("interactionChoice")] 
		public gameinteractionsChoice InteractionChoice
		{
			get => GetPropertyValue<gameinteractionsChoice>();
			set => SetPropertyValue<gameinteractionsChoice>(value);
		}

		[Ordinal(12)] 
		[RED("interactionLayer")] 
		public CName InteractionLayer
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("isActionRPGCheckDissabled")] 
		public CBool IsActionRPGCheckDissabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("canSkipPayCost")] 
		public CBool CanSkipPayCost
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("calculatedBaseCost")] 
		public CInt32 CalculatedBaseCost
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(16)] 
		[RED("deviceActionQueue")] 
		public CHandle<DeviceActionQueue> DeviceActionQueue
		{
			get => GetPropertyValue<CHandle<DeviceActionQueue>>();
			set => SetPropertyValue<CHandle<DeviceActionQueue>>(value);
		}

		[Ordinal(17)] 
		[RED("isActionQueueingUsed")] 
		public CBool IsActionQueueingUsed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("isQueuedAction")] 
		public CBool IsQueuedAction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("isInactive")] 
		public CBool IsInactive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("isTargetDead")] 
		public CBool IsTargetDead
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("activationTimeReduction")] 
		public CFloat ActivationTimeReduction
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("IsAppliedByMonowire")] 
		public CBool IsAppliedByMonowire
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public BaseScriptableAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

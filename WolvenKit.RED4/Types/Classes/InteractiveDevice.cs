using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InteractiveDevice : Device
	{
		[Ordinal(88)] 
		[RED("interaction")] 
		public CHandle<gameinteractionsComponent> Interaction
		{
			get => GetPropertyValue<CHandle<gameinteractionsComponent>>();
			set => SetPropertyValue<CHandle<gameinteractionsComponent>>(value);
		}

		[Ordinal(89)] 
		[RED("interactionIndicator")] 
		public CHandle<gameLightComponent> InteractionIndicator
		{
			get => GetPropertyValue<CHandle<gameLightComponent>>();
			set => SetPropertyValue<CHandle<gameLightComponent>>(value);
		}

		[Ordinal(90)] 
		[RED("disableAreaIndicatorID")] 
		public gameDelayID DisableAreaIndicatorID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(91)] 
		[RED("delayedUIRefreshID")] 
		public gameDelayID DelayedUIRefreshID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(92)] 
		[RED("isPlayerAround")] 
		public CBool IsPlayerAround
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(93)] 
		[RED("disableAreaIndicatorDelayActive")] 
		public CBool DisableAreaIndicatorDelayActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(94)] 
		[RED("objectActionsCallbackCtrl")] 
		public CHandle<gameObjectActionsCallbackController> ObjectActionsCallbackCtrl
		{
			get => GetPropertyValue<CHandle<gameObjectActionsCallbackController>>();
			set => SetPropertyValue<CHandle<gameObjectActionsCallbackController>>(value);
		}

		[Ordinal(95)] 
		[RED("investigationData")] 
		public CArray<InvestigationData> InvestigationData
		{
			get => GetPropertyValue<CArray<InvestigationData>>();
			set => SetPropertyValue<CArray<InvestigationData>>(value);
		}

		[Ordinal(96)] 
		[RED("actionRestrictionPlayerBB")] 
		public CWeakHandle<gameIBlackboard> ActionRestrictionPlayerBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(97)] 
		[RED("actionRestrictionCallbackID")] 
		public CHandle<redCallbackObject> ActionRestrictionCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public InteractiveDevice()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InteractiveDevice : Device
	{
		[Ordinal(84)] 
		[RED("interaction")] 
		public CHandle<gameinteractionsComponent> Interaction
		{
			get => GetPropertyValue<CHandle<gameinteractionsComponent>>();
			set => SetPropertyValue<CHandle<gameinteractionsComponent>>(value);
		}

		[Ordinal(85)] 
		[RED("interactionIndicator")] 
		public CHandle<gameLightComponent> InteractionIndicator
		{
			get => GetPropertyValue<CHandle<gameLightComponent>>();
			set => SetPropertyValue<CHandle<gameLightComponent>>(value);
		}

		[Ordinal(86)] 
		[RED("disableAreaIndicatorID")] 
		public gameDelayID DisableAreaIndicatorID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(87)] 
		[RED("delayedUIRefreshID")] 
		public gameDelayID DelayedUIRefreshID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(88)] 
		[RED("isPlayerAround")] 
		public CBool IsPlayerAround
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(89)] 
		[RED("disableAreaIndicatorDelayActive")] 
		public CBool DisableAreaIndicatorDelayActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(90)] 
		[RED("objectActionsCallbackCtrl")] 
		public CHandle<gameObjectActionsCallbackController> ObjectActionsCallbackCtrl
		{
			get => GetPropertyValue<CHandle<gameObjectActionsCallbackController>>();
			set => SetPropertyValue<CHandle<gameObjectActionsCallbackController>>(value);
		}

		[Ordinal(91)] 
		[RED("investigationPositionsArray")] 
		public CArray<Vector4> InvestigationPositionsArray
		{
			get => GetPropertyValue<CArray<Vector4>>();
			set => SetPropertyValue<CArray<Vector4>>(value);
		}

		[Ordinal(92)] 
		[RED("actionRestrictionPlayerBB")] 
		public CWeakHandle<gameIBlackboard> ActionRestrictionPlayerBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(93)] 
		[RED("actionRestrictionCallbackID")] 
		public CHandle<redCallbackObject> ActionRestrictionCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public InteractiveDevice()
		{
			DisableAreaIndicatorID = new();
			DelayedUIRefreshID = new();
			InvestigationPositionsArray = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DatatermDetailGameController : BaseBunkerComputerGameController
	{
		[Ordinal(4)] 
		[RED("authFactsSet")] 
		public AuthorizationFactsSet AuthFactsSet
		{
			get => GetPropertyValue<AuthorizationFactsSet>();
			set => SetPropertyValue<AuthorizationFactsSet>(value);
		}

		[Ordinal(5)] 
		[RED("attemptedFactsSet")] 
		public AttemptedToStopFactsSet AttemptedFactsSet
		{
			get => GetPropertyValue<AttemptedToStopFactsSet>();
			set => SetPropertyValue<AttemptedToStopFactsSet>(value);
		}

		[Ordinal(6)] 
		[RED("systemStatusHeaderPannel")] 
		public inkWidgetReference SystemStatusHeaderPannel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("systemStatusLeftPannel")] 
		public inkWidgetReference SystemStatusLeftPannel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("systemStatusRightPannel")] 
		public inkWidgetReference SystemStatusRightPannel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("loopAnimName")] 
		public CName LoopAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("popup01Counter")] 
		public CInt32 Popup01Counter
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("popup02Counter")] 
		public CInt32 Popup02Counter
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(12)] 
		[RED("popup01LoopAnimName")] 
		public CName Popup01LoopAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("popup02LoopAnimName")] 
		public CName Popup02LoopAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("popup031LoopAnimName")] 
		public CName Popup031LoopAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("popup032LoopAnimName")] 
		public CName Popup032LoopAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("popup04LoopAnimName")] 
		public CName Popup04LoopAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("popup05LoopAnimName")] 
		public CName Popup05LoopAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("shutdownButton")] 
		public inkWidgetReference ShutdownButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("transitionToMinigame")] 
		public inkWidgetReference TransitionToMinigame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("popup01LoopAnimProxy")] 
		public CHandle<inkanimProxy> Popup01LoopAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(21)] 
		[RED("isAuthStep")] 
		public CBool IsAuthStep
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("isHackingStep")] 
		public CBool IsHackingStep
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("isPostHackingStep")] 
		public CBool IsPostHackingStep
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("isOffline")] 
		public CBool IsOffline
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("isAttemptedToStop")] 
		public CBool IsAttemptedToStop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DatatermDetailGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

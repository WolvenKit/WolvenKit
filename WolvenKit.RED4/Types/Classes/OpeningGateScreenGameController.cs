using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OpeningGateScreenGameController : BaseBunkerComputerGameController
	{
		[Ordinal(4)] 
		[RED("systemConsole")] 
		public inkWidgetReference SystemConsole
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("gateScheme")] 
		public inkWidgetReference GateScheme
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("backButton")] 
		public inkWidgetReference BackButton
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("idleAnimName")] 
		public CName IdleAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("loopAnimName")] 
		public CName LoopAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("failureAnimName")] 
		public CName FailureAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("successAnimName")] 
		public CName SuccessAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("failurePopupIntroAnimName")] 
		public CName FailurePopupIntroAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("successPopupIntroAnimName")] 
		public CName SuccessPopupIntroAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("failurePopupAnimName")] 
		public CName FailurePopupAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("successPopupAnimName")] 
		public CName SuccessPopupAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("gateIsOpenedFact")] 
		public CName GateIsOpenedFact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("gateChainBeginningFact")] 
		public CName GateChainBeginningFact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("gotoLoopDelay")] 
		public CFloat GotoLoopDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("goBackDelay")] 
		public CFloat GoBackDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("isGateOpened")] 
		public CBool IsGateOpened
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("systemsStatus")] 
		public CArray<CBool> SystemsStatus
		{
			get => GetPropertyValue<CArray<CBool>>();
			set => SetPropertyValue<CArray<CBool>>(value);
		}

		[Ordinal(21)] 
		[RED("currentLoopIndex")] 
		public CInt32 CurrentLoopIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(22)] 
		[RED("currentSystemIndex")] 
		public CInt32 CurrentSystemIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(23)] 
		[RED("phasesCount")] 
		public CInt32 PhasesCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(24)] 
		[RED("state")] 
		public CEnum<OpeningGateScreenState> State
		{
			get => GetPropertyValue<CEnum<OpeningGateScreenState>>();
			set => SetPropertyValue<CEnum<OpeningGateScreenState>>(value);
		}

		[Ordinal(25)] 
		[RED("idleAnimProxy")] 
		public CHandle<inkanimProxy> IdleAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(26)] 
		[RED("loopAnimProxy")] 
		public CHandle<inkanimProxy> LoopAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(27)] 
		[RED("resultAnimProxy")] 
		public CHandle<inkanimProxy> ResultAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(28)] 
		[RED("resultPopupIntroAnimProxy")] 
		public CHandle<inkanimProxy> ResultPopupIntroAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(29)] 
		[RED("resultPopupAnimProxy")] 
		public CHandle<inkanimProxy> ResultPopupAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public OpeningGateScreenGameController()
		{
			SystemConsole = new inkWidgetReference();
			GateScheme = new inkWidgetReference();
			BackButton = new inkWidgetReference();
			IdleAnimName = "idle_state";
			LoopAnimName = "loop_state";
			FailureAnimName = "failure_state";
			SuccessAnimName = "success_state";
			FailurePopupIntroAnimName = "popup2_intro";
			SuccessPopupIntroAnimName = "popup1_intro";
			FailurePopupAnimName = "popup2_loop";
			SuccessPopupAnimName = "popup1_loop";
			GateIsOpenedFact = "q305_open_the_gate";
			GateChainBeginningFact = "Q305_gate_chain_beginning";
			GotoLoopDelay = 2.500000F;
			GoBackDelay = 6.000000F;
			SystemsStatus = new();
			PhasesCount = 3;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GamepadLightScriptableSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("controllerCurrentColor")] 
		public Vector3 ControllerCurrentColor
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(1)] 
		[RED("controllerStartColor")] 
		public Vector3 ControllerStartColor
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(2)] 
		[RED("controllerTargetColor")] 
		public Vector3 ControllerTargetColor
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(3)] 
		[RED("currentProgress")] 
		public CFloat CurrentProgress
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("useExponentialCurve")] 
		public CBool UseExponentialCurve
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("prevTime")] 
		public CFloat PrevTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("currentState")] 
		public CEnum<ELightState> CurrentState
		{
			get => GetPropertyValue<CEnum<ELightState>>();
			set => SetPropertyValue<CEnum<ELightState>>(value);
		}

		[Ordinal(7)] 
		[RED("prevState")] 
		public CEnum<ELightState> PrevState
		{
			get => GetPropertyValue<CEnum<ELightState>>();
			set => SetPropertyValue<CEnum<ELightState>>(value);
		}

		[Ordinal(8)] 
		[RED("timeLimit")] 
		public CFloat TimeLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("currrentId")] 
		public gameDelayID CurrrentId
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		public GamepadLightScriptableSystem()
		{
			ControllerCurrentColor = new Vector3();
			ControllerStartColor = new Vector3();
			ControllerTargetColor = new Vector3();
			CurrrentId = new gameDelayID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

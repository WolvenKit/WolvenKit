using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BraindanceSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("inputMask")] 
		public SBraindanceInputMask InputMask
		{
			get => GetPropertyValue<SBraindanceInputMask>();
			set => SetPropertyValue<SBraindanceInputMask>(value);
		}

		[Ordinal(1)] 
		[RED("requestCameraToggle")] 
		public CBool RequestCameraToggle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("requestEditorState")] 
		public CBool RequestEditorState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("pauseBraindanceRequest")] 
		public CBool PauseBraindanceRequest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("isInBraindance")] 
		public CBool IsInBraindance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("debugFFSceneThrehsold")] 
		public CInt32 DebugFFSceneThrehsold
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public BraindanceSystem()
		{
			InputMask = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BraindanceSystem : gameScriptableSystem
	{
		private SBraindanceInputMask _inputMask;
		private CBool _requestCameraToggle;
		private CBool _requestEditorState;
		private CBool _pauseBraindanceRequest;
		private CBool _isInBraindance;
		private CInt32 _debugFFSceneThrehsold;

		[Ordinal(0)] 
		[RED("inputMask")] 
		public SBraindanceInputMask InputMask
		{
			get => GetProperty(ref _inputMask);
			set => SetProperty(ref _inputMask, value);
		}

		[Ordinal(1)] 
		[RED("requestCameraToggle")] 
		public CBool RequestCameraToggle
		{
			get => GetProperty(ref _requestCameraToggle);
			set => SetProperty(ref _requestCameraToggle, value);
		}

		[Ordinal(2)] 
		[RED("requestEditorState")] 
		public CBool RequestEditorState
		{
			get => GetProperty(ref _requestEditorState);
			set => SetProperty(ref _requestEditorState, value);
		}

		[Ordinal(3)] 
		[RED("pauseBraindanceRequest")] 
		public CBool PauseBraindanceRequest
		{
			get => GetProperty(ref _pauseBraindanceRequest);
			set => SetProperty(ref _pauseBraindanceRequest, value);
		}

		[Ordinal(4)] 
		[RED("isInBraindance")] 
		public CBool IsInBraindance
		{
			get => GetProperty(ref _isInBraindance);
			set => SetProperty(ref _isInBraindance, value);
		}

		[Ordinal(5)] 
		[RED("debugFFSceneThrehsold")] 
		public CInt32 DebugFFSceneThrehsold
		{
			get => GetProperty(ref _debugFFSceneThrehsold);
			set => SetProperty(ref _debugFFSceneThrehsold, value);
		}

		public BraindanceSystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

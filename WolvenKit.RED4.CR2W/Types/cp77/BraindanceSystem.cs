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
			get
			{
				if (_inputMask == null)
				{
					_inputMask = (SBraindanceInputMask) CR2WTypeManager.Create("SBraindanceInputMask", "inputMask", cr2w, this);
				}
				return _inputMask;
			}
			set
			{
				if (_inputMask == value)
				{
					return;
				}
				_inputMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("requestCameraToggle")] 
		public CBool RequestCameraToggle
		{
			get
			{
				if (_requestCameraToggle == null)
				{
					_requestCameraToggle = (CBool) CR2WTypeManager.Create("Bool", "requestCameraToggle", cr2w, this);
				}
				return _requestCameraToggle;
			}
			set
			{
				if (_requestCameraToggle == value)
				{
					return;
				}
				_requestCameraToggle = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("requestEditorState")] 
		public CBool RequestEditorState
		{
			get
			{
				if (_requestEditorState == null)
				{
					_requestEditorState = (CBool) CR2WTypeManager.Create("Bool", "requestEditorState", cr2w, this);
				}
				return _requestEditorState;
			}
			set
			{
				if (_requestEditorState == value)
				{
					return;
				}
				_requestEditorState = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("pauseBraindanceRequest")] 
		public CBool PauseBraindanceRequest
		{
			get
			{
				if (_pauseBraindanceRequest == null)
				{
					_pauseBraindanceRequest = (CBool) CR2WTypeManager.Create("Bool", "pauseBraindanceRequest", cr2w, this);
				}
				return _pauseBraindanceRequest;
			}
			set
			{
				if (_pauseBraindanceRequest == value)
				{
					return;
				}
				_pauseBraindanceRequest = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isInBraindance")] 
		public CBool IsInBraindance
		{
			get
			{
				if (_isInBraindance == null)
				{
					_isInBraindance = (CBool) CR2WTypeManager.Create("Bool", "isInBraindance", cr2w, this);
				}
				return _isInBraindance;
			}
			set
			{
				if (_isInBraindance == value)
				{
					return;
				}
				_isInBraindance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("debugFFSceneThrehsold")] 
		public CInt32 DebugFFSceneThrehsold
		{
			get
			{
				if (_debugFFSceneThrehsold == null)
				{
					_debugFFSceneThrehsold = (CInt32) CR2WTypeManager.Create("Int32", "debugFFSceneThrehsold", cr2w, this);
				}
				return _debugFFSceneThrehsold;
			}
			set
			{
				if (_debugFFSceneThrehsold == value)
				{
					return;
				}
				_debugFFSceneThrehsold = value;
				PropertySet(this);
			}
		}

		public BraindanceSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

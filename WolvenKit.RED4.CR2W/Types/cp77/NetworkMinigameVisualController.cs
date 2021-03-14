using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameVisualController : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _gridContainer;
		private inkVideoWidgetReference _middleVideoContainer;
		private inkWidgetReference _sidesAnimContainer;
		private redResourceReferenceScriptToken _sidesLibraryPath;
		private CName _introAnimationLibraryName;
		private CName _gridOutroAnimationLibraryName;
		private CName _endScreenIntroAnimationLibraryName;
		private inkWidgetReference _programsContainer;
		private inkWidgetReference _bufferContainer;
		private inkWidgetReference _endScreenContainer;
		private CArray<inkWidgetReference> _fluffToHideContainer;
		private CArray<inkWidgetReference> _dottedLinesList;
		private inkWidgetReference _basicAccessContainer;
		private inkWidgetReference _animationCallbackContainer;
		private inkWidgetReference _dotMask;
		private CFloat _linesToGridOffset;
		private CFloat _linesSeparationDistance;
		private wCHandle<NetworkMinigameAnimationCallbacksTransmitter> _animationCallback;
		private wCHandle<NetworkMinigameGridController> _grid;
		private inkWidgetReference _gridController;
		private inkWidgetReference _programListController;
		private inkWidgetReference _bufferController;
		private inkWidgetReference _endScreenController;
		private wCHandle<NetworkMinigameProgramListController> _programList;
		private wCHandle<NetworkMinigameBufferController> _buffer;
		private wCHandle<NetworkMinigameEndScreenController> _endScreen;
		private wCHandle<NetworkMinigameBasicProgramController> _basicAccess;
		private wCHandle<inkWidget> _sidesAnim;
		private CInt32 _bufferFillCount;
		private CHandle<inkanimProxy> _bufferAnimProxy;
		private CHandle<inkanimDefinition> _fillProgress;

		[Ordinal(1)] 
		[RED("gridContainer")] 
		public inkCompoundWidgetReference GridContainer
		{
			get
			{
				if (_gridContainer == null)
				{
					_gridContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "gridContainer", cr2w, this);
				}
				return _gridContainer;
			}
			set
			{
				if (_gridContainer == value)
				{
					return;
				}
				_gridContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("middleVideoContainer")] 
		public inkVideoWidgetReference MiddleVideoContainer
		{
			get
			{
				if (_middleVideoContainer == null)
				{
					_middleVideoContainer = (inkVideoWidgetReference) CR2WTypeManager.Create("inkVideoWidgetReference", "middleVideoContainer", cr2w, this);
				}
				return _middleVideoContainer;
			}
			set
			{
				if (_middleVideoContainer == value)
				{
					return;
				}
				_middleVideoContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("sidesAnimContainer")] 
		public inkWidgetReference SidesAnimContainer
		{
			get
			{
				if (_sidesAnimContainer == null)
				{
					_sidesAnimContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "sidesAnimContainer", cr2w, this);
				}
				return _sidesAnimContainer;
			}
			set
			{
				if (_sidesAnimContainer == value)
				{
					return;
				}
				_sidesAnimContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("sidesLibraryPath")] 
		public redResourceReferenceScriptToken SidesLibraryPath
		{
			get
			{
				if (_sidesLibraryPath == null)
				{
					_sidesLibraryPath = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "sidesLibraryPath", cr2w, this);
				}
				return _sidesLibraryPath;
			}
			set
			{
				if (_sidesLibraryPath == value)
				{
					return;
				}
				_sidesLibraryPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("introAnimationLibraryName")] 
		public CName IntroAnimationLibraryName
		{
			get
			{
				if (_introAnimationLibraryName == null)
				{
					_introAnimationLibraryName = (CName) CR2WTypeManager.Create("CName", "introAnimationLibraryName", cr2w, this);
				}
				return _introAnimationLibraryName;
			}
			set
			{
				if (_introAnimationLibraryName == value)
				{
					return;
				}
				_introAnimationLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("gridOutroAnimationLibraryName")] 
		public CName GridOutroAnimationLibraryName
		{
			get
			{
				if (_gridOutroAnimationLibraryName == null)
				{
					_gridOutroAnimationLibraryName = (CName) CR2WTypeManager.Create("CName", "gridOutroAnimationLibraryName", cr2w, this);
				}
				return _gridOutroAnimationLibraryName;
			}
			set
			{
				if (_gridOutroAnimationLibraryName == value)
				{
					return;
				}
				_gridOutroAnimationLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("endScreenIntroAnimationLibraryName")] 
		public CName EndScreenIntroAnimationLibraryName
		{
			get
			{
				if (_endScreenIntroAnimationLibraryName == null)
				{
					_endScreenIntroAnimationLibraryName = (CName) CR2WTypeManager.Create("CName", "endScreenIntroAnimationLibraryName", cr2w, this);
				}
				return _endScreenIntroAnimationLibraryName;
			}
			set
			{
				if (_endScreenIntroAnimationLibraryName == value)
				{
					return;
				}
				_endScreenIntroAnimationLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("programsContainer")] 
		public inkWidgetReference ProgramsContainer
		{
			get
			{
				if (_programsContainer == null)
				{
					_programsContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "programsContainer", cr2w, this);
				}
				return _programsContainer;
			}
			set
			{
				if (_programsContainer == value)
				{
					return;
				}
				_programsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("bufferContainer")] 
		public inkWidgetReference BufferContainer
		{
			get
			{
				if (_bufferContainer == null)
				{
					_bufferContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "bufferContainer", cr2w, this);
				}
				return _bufferContainer;
			}
			set
			{
				if (_bufferContainer == value)
				{
					return;
				}
				_bufferContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("endScreenContainer")] 
		public inkWidgetReference EndScreenContainer
		{
			get
			{
				if (_endScreenContainer == null)
				{
					_endScreenContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "endScreenContainer", cr2w, this);
				}
				return _endScreenContainer;
			}
			set
			{
				if (_endScreenContainer == value)
				{
					return;
				}
				_endScreenContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("FluffToHideContainer")] 
		public CArray<inkWidgetReference> FluffToHideContainer
		{
			get
			{
				if (_fluffToHideContainer == null)
				{
					_fluffToHideContainer = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "FluffToHideContainer", cr2w, this);
				}
				return _fluffToHideContainer;
			}
			set
			{
				if (_fluffToHideContainer == value)
				{
					return;
				}
				_fluffToHideContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("DottedLinesList")] 
		public CArray<inkWidgetReference> DottedLinesList
		{
			get
			{
				if (_dottedLinesList == null)
				{
					_dottedLinesList = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "DottedLinesList", cr2w, this);
				}
				return _dottedLinesList;
			}
			set
			{
				if (_dottedLinesList == value)
				{
					return;
				}
				_dottedLinesList = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("basicAccessContainer")] 
		public inkWidgetReference BasicAccessContainer
		{
			get
			{
				if (_basicAccessContainer == null)
				{
					_basicAccessContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "basicAccessContainer", cr2w, this);
				}
				return _basicAccessContainer;
			}
			set
			{
				if (_basicAccessContainer == value)
				{
					return;
				}
				_basicAccessContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("animationCallbackContainer")] 
		public inkWidgetReference AnimationCallbackContainer
		{
			get
			{
				if (_animationCallbackContainer == null)
				{
					_animationCallbackContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "animationCallbackContainer", cr2w, this);
				}
				return _animationCallbackContainer;
			}
			set
			{
				if (_animationCallbackContainer == value)
				{
					return;
				}
				_animationCallbackContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("dotMask")] 
		public inkWidgetReference DotMask
		{
			get
			{
				if (_dotMask == null)
				{
					_dotMask = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "dotMask", cr2w, this);
				}
				return _dotMask;
			}
			set
			{
				if (_dotMask == value)
				{
					return;
				}
				_dotMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("linesToGridOffset")] 
		public CFloat LinesToGridOffset
		{
			get
			{
				if (_linesToGridOffset == null)
				{
					_linesToGridOffset = (CFloat) CR2WTypeManager.Create("Float", "linesToGridOffset", cr2w, this);
				}
				return _linesToGridOffset;
			}
			set
			{
				if (_linesToGridOffset == value)
				{
					return;
				}
				_linesToGridOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("linesSeparationDistance")] 
		public CFloat LinesSeparationDistance
		{
			get
			{
				if (_linesSeparationDistance == null)
				{
					_linesSeparationDistance = (CFloat) CR2WTypeManager.Create("Float", "linesSeparationDistance", cr2w, this);
				}
				return _linesSeparationDistance;
			}
			set
			{
				if (_linesSeparationDistance == value)
				{
					return;
				}
				_linesSeparationDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("animationCallback")] 
		public wCHandle<NetworkMinigameAnimationCallbacksTransmitter> AnimationCallback
		{
			get
			{
				if (_animationCallback == null)
				{
					_animationCallback = (wCHandle<NetworkMinigameAnimationCallbacksTransmitter>) CR2WTypeManager.Create("whandle:NetworkMinigameAnimationCallbacksTransmitter", "animationCallback", cr2w, this);
				}
				return _animationCallback;
			}
			set
			{
				if (_animationCallback == value)
				{
					return;
				}
				_animationCallback = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("grid")] 
		public wCHandle<NetworkMinigameGridController> Grid
		{
			get
			{
				if (_grid == null)
				{
					_grid = (wCHandle<NetworkMinigameGridController>) CR2WTypeManager.Create("whandle:NetworkMinigameGridController", "grid", cr2w, this);
				}
				return _grid;
			}
			set
			{
				if (_grid == value)
				{
					return;
				}
				_grid = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("gridController")] 
		public inkWidgetReference GridController
		{
			get
			{
				if (_gridController == null)
				{
					_gridController = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "gridController", cr2w, this);
				}
				return _gridController;
			}
			set
			{
				if (_gridController == value)
				{
					return;
				}
				_gridController = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("programListController")] 
		public inkWidgetReference ProgramListController
		{
			get
			{
				if (_programListController == null)
				{
					_programListController = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "programListController", cr2w, this);
				}
				return _programListController;
			}
			set
			{
				if (_programListController == value)
				{
					return;
				}
				_programListController = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("bufferController")] 
		public inkWidgetReference BufferController
		{
			get
			{
				if (_bufferController == null)
				{
					_bufferController = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "bufferController", cr2w, this);
				}
				return _bufferController;
			}
			set
			{
				if (_bufferController == value)
				{
					return;
				}
				_bufferController = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("endScreenController")] 
		public inkWidgetReference EndScreenController
		{
			get
			{
				if (_endScreenController == null)
				{
					_endScreenController = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "endScreenController", cr2w, this);
				}
				return _endScreenController;
			}
			set
			{
				if (_endScreenController == value)
				{
					return;
				}
				_endScreenController = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("programList")] 
		public wCHandle<NetworkMinigameProgramListController> ProgramList
		{
			get
			{
				if (_programList == null)
				{
					_programList = (wCHandle<NetworkMinigameProgramListController>) CR2WTypeManager.Create("whandle:NetworkMinigameProgramListController", "programList", cr2w, this);
				}
				return _programList;
			}
			set
			{
				if (_programList == value)
				{
					return;
				}
				_programList = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("buffer")] 
		public wCHandle<NetworkMinigameBufferController> Buffer
		{
			get
			{
				if (_buffer == null)
				{
					_buffer = (wCHandle<NetworkMinigameBufferController>) CR2WTypeManager.Create("whandle:NetworkMinigameBufferController", "buffer", cr2w, this);
				}
				return _buffer;
			}
			set
			{
				if (_buffer == value)
				{
					return;
				}
				_buffer = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("endScreen")] 
		public wCHandle<NetworkMinigameEndScreenController> EndScreen
		{
			get
			{
				if (_endScreen == null)
				{
					_endScreen = (wCHandle<NetworkMinigameEndScreenController>) CR2WTypeManager.Create("whandle:NetworkMinigameEndScreenController", "endScreen", cr2w, this);
				}
				return _endScreen;
			}
			set
			{
				if (_endScreen == value)
				{
					return;
				}
				_endScreen = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("basicAccess")] 
		public wCHandle<NetworkMinigameBasicProgramController> BasicAccess
		{
			get
			{
				if (_basicAccess == null)
				{
					_basicAccess = (wCHandle<NetworkMinigameBasicProgramController>) CR2WTypeManager.Create("whandle:NetworkMinigameBasicProgramController", "basicAccess", cr2w, this);
				}
				return _basicAccess;
			}
			set
			{
				if (_basicAccess == value)
				{
					return;
				}
				_basicAccess = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("sidesAnim")] 
		public wCHandle<inkWidget> SidesAnim
		{
			get
			{
				if (_sidesAnim == null)
				{
					_sidesAnim = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "sidesAnim", cr2w, this);
				}
				return _sidesAnim;
			}
			set
			{
				if (_sidesAnim == value)
				{
					return;
				}
				_sidesAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("bufferFillCount")] 
		public CInt32 BufferFillCount
		{
			get
			{
				if (_bufferFillCount == null)
				{
					_bufferFillCount = (CInt32) CR2WTypeManager.Create("Int32", "bufferFillCount", cr2w, this);
				}
				return _bufferFillCount;
			}
			set
			{
				if (_bufferFillCount == value)
				{
					return;
				}
				_bufferFillCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("bufferAnimProxy")] 
		public CHandle<inkanimProxy> BufferAnimProxy
		{
			get
			{
				if (_bufferAnimProxy == null)
				{
					_bufferAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "bufferAnimProxy", cr2w, this);
				}
				return _bufferAnimProxy;
			}
			set
			{
				if (_bufferAnimProxy == value)
				{
					return;
				}
				_bufferAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("fillProgress")] 
		public CHandle<inkanimDefinition> FillProgress
		{
			get
			{
				if (_fillProgress == null)
				{
					_fillProgress = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "fillProgress", cr2w, this);
				}
				return _fillProgress;
			}
			set
			{
				if (_fillProgress == value)
				{
					return;
				}
				_fillProgress = value;
				PropertySet(this);
			}
		}

		public NetworkMinigameVisualController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

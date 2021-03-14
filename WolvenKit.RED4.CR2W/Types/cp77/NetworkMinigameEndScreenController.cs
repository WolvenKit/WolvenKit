using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameEndScreenController : inkWidgetLogicController
	{
		private inkTextWidgetReference _outcomeText;
		private wCHandle<NetworkMinigameProgramController> _finishBarContainer;
		private inkWidgetReference _programsListContainer;
		private CName _programLibraryName;
		private CArray<wCHandle<NetworkMinigameProgramController>> _slotList;
		private EndScreenData _endData;
		private inkWidgetReference _closeButton;
		private inkWidgetReference _header_bg;
		private CColor _completionColor;
		private CColor _failureColor;

		[Ordinal(1)] 
		[RED("outcomeText")] 
		public inkTextWidgetReference OutcomeText
		{
			get
			{
				if (_outcomeText == null)
				{
					_outcomeText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "outcomeText", cr2w, this);
				}
				return _outcomeText;
			}
			set
			{
				if (_outcomeText == value)
				{
					return;
				}
				_outcomeText = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("finishBarContainer")] 
		public wCHandle<NetworkMinigameProgramController> FinishBarContainer
		{
			get
			{
				if (_finishBarContainer == null)
				{
					_finishBarContainer = (wCHandle<NetworkMinigameProgramController>) CR2WTypeManager.Create("whandle:NetworkMinigameProgramController", "finishBarContainer", cr2w, this);
				}
				return _finishBarContainer;
			}
			set
			{
				if (_finishBarContainer == value)
				{
					return;
				}
				_finishBarContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("programsListContainer")] 
		public inkWidgetReference ProgramsListContainer
		{
			get
			{
				if (_programsListContainer == null)
				{
					_programsListContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "programsListContainer", cr2w, this);
				}
				return _programsListContainer;
			}
			set
			{
				if (_programsListContainer == value)
				{
					return;
				}
				_programsListContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("programLibraryName")] 
		public CName ProgramLibraryName
		{
			get
			{
				if (_programLibraryName == null)
				{
					_programLibraryName = (CName) CR2WTypeManager.Create("CName", "programLibraryName", cr2w, this);
				}
				return _programLibraryName;
			}
			set
			{
				if (_programLibraryName == value)
				{
					return;
				}
				_programLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("slotList")] 
		public CArray<wCHandle<NetworkMinigameProgramController>> SlotList
		{
			get
			{
				if (_slotList == null)
				{
					_slotList = (CArray<wCHandle<NetworkMinigameProgramController>>) CR2WTypeManager.Create("array:whandle:NetworkMinigameProgramController", "slotList", cr2w, this);
				}
				return _slotList;
			}
			set
			{
				if (_slotList == value)
				{
					return;
				}
				_slotList = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("endData")] 
		public EndScreenData EndData
		{
			get
			{
				if (_endData == null)
				{
					_endData = (EndScreenData) CR2WTypeManager.Create("EndScreenData", "endData", cr2w, this);
				}
				return _endData;
			}
			set
			{
				if (_endData == value)
				{
					return;
				}
				_endData = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("closeButton")] 
		public inkWidgetReference CloseButton
		{
			get
			{
				if (_closeButton == null)
				{
					_closeButton = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "closeButton", cr2w, this);
				}
				return _closeButton;
			}
			set
			{
				if (_closeButton == value)
				{
					return;
				}
				_closeButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("header_bg")] 
		public inkWidgetReference Header_bg
		{
			get
			{
				if (_header_bg == null)
				{
					_header_bg = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "header_bg", cr2w, this);
				}
				return _header_bg;
			}
			set
			{
				if (_header_bg == value)
				{
					return;
				}
				_header_bg = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("completionColor")] 
		public CColor CompletionColor
		{
			get
			{
				if (_completionColor == null)
				{
					_completionColor = (CColor) CR2WTypeManager.Create("Color", "completionColor", cr2w, this);
				}
				return _completionColor;
			}
			set
			{
				if (_completionColor == value)
				{
					return;
				}
				_completionColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("failureColor")] 
		public CColor FailureColor
		{
			get
			{
				if (_failureColor == null)
				{
					_failureColor = (CColor) CR2WTypeManager.Create("Color", "failureColor", cr2w, this);
				}
				return _failureColor;
			}
			set
			{
				if (_failureColor == value)
				{
					return;
				}
				_failureColor = value;
				PropertySet(this);
			}
		}

		public NetworkMinigameEndScreenController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

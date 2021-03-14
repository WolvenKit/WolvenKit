using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameProgramListController : inkWidgetLogicController
	{
		private inkWidgetReference _programPlayerContainer;
		private inkWidgetReference _programNetworkContainer;
		private CName _programLibraryName;
		private CArray<wCHandle<NetworkMinigameProgramController>> _slotList;
		private CHandle<inkanimProxy> _animProxy_02;
		private inkWidgetReference _headerBG;

		[Ordinal(1)] 
		[RED("programPlayerContainer")] 
		public inkWidgetReference ProgramPlayerContainer
		{
			get
			{
				if (_programPlayerContainer == null)
				{
					_programPlayerContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "programPlayerContainer", cr2w, this);
				}
				return _programPlayerContainer;
			}
			set
			{
				if (_programPlayerContainer == value)
				{
					return;
				}
				_programPlayerContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("programNetworkContainer")] 
		public inkWidgetReference ProgramNetworkContainer
		{
			get
			{
				if (_programNetworkContainer == null)
				{
					_programNetworkContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "programNetworkContainer", cr2w, this);
				}
				return _programNetworkContainer;
			}
			set
			{
				if (_programNetworkContainer == value)
				{
					return;
				}
				_programNetworkContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("animProxy_02")] 
		public CHandle<inkanimProxy> AnimProxy_02
		{
			get
			{
				if (_animProxy_02 == null)
				{
					_animProxy_02 = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxy_02", cr2w, this);
				}
				return _animProxy_02;
			}
			set
			{
				if (_animProxy_02 == value)
				{
					return;
				}
				_animProxy_02 = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("headerBG")] 
		public inkWidgetReference HeaderBG
		{
			get
			{
				if (_headerBG == null)
				{
					_headerBG = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "headerBG", cr2w, this);
				}
				return _headerBG;
			}
			set
			{
				if (_headerBG == value)
				{
					return;
				}
				_headerBG = value;
				PropertySet(this);
			}
		}

		public NetworkMinigameProgramListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

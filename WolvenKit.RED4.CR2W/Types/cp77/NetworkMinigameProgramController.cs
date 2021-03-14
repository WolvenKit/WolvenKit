using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameProgramController : inkWidgetLogicController
	{
		private inkTextWidgetReference _text;
		private CArray<inkWidgetReference> _commandElementSlotsContainer;
		private CName _elementLibraryName;
		private inkWidgetReference _completedMarker;
		private inkImageWidgetReference _imageRef;
		private CArray<CArray<wCHandle<NetworkMinigameElementController>>> _slotList;
		private ProgramData _data;
		private CHandle<inkanimProxy> _animProxy;

		[Ordinal(1)] 
		[RED("text")] 
		public inkTextWidgetReference Text
		{
			get
			{
				if (_text == null)
				{
					_text = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "text", cr2w, this);
				}
				return _text;
			}
			set
			{
				if (_text == value)
				{
					return;
				}
				_text = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("commandElementSlotsContainer")] 
		public CArray<inkWidgetReference> CommandElementSlotsContainer
		{
			get
			{
				if (_commandElementSlotsContainer == null)
				{
					_commandElementSlotsContainer = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "commandElementSlotsContainer", cr2w, this);
				}
				return _commandElementSlotsContainer;
			}
			set
			{
				if (_commandElementSlotsContainer == value)
				{
					return;
				}
				_commandElementSlotsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("elementLibraryName")] 
		public CName ElementLibraryName
		{
			get
			{
				if (_elementLibraryName == null)
				{
					_elementLibraryName = (CName) CR2WTypeManager.Create("CName", "elementLibraryName", cr2w, this);
				}
				return _elementLibraryName;
			}
			set
			{
				if (_elementLibraryName == value)
				{
					return;
				}
				_elementLibraryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("completedMarker")] 
		public inkWidgetReference CompletedMarker
		{
			get
			{
				if (_completedMarker == null)
				{
					_completedMarker = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "completedMarker", cr2w, this);
				}
				return _completedMarker;
			}
			set
			{
				if (_completedMarker == value)
				{
					return;
				}
				_completedMarker = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("imageRef")] 
		public inkImageWidgetReference ImageRef
		{
			get
			{
				if (_imageRef == null)
				{
					_imageRef = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "imageRef", cr2w, this);
				}
				return _imageRef;
			}
			set
			{
				if (_imageRef == value)
				{
					return;
				}
				_imageRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("slotList")] 
		public CArray<CArray<wCHandle<NetworkMinigameElementController>>> SlotList
		{
			get
			{
				if (_slotList == null)
				{
					_slotList = (CArray<CArray<wCHandle<NetworkMinigameElementController>>>) CR2WTypeManager.Create("array:array:whandle:NetworkMinigameElementController", "slotList", cr2w, this);
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

		[Ordinal(7)] 
		[RED("data")] 
		public ProgramData Data
		{
			get
			{
				if (_data == null)
				{
					_data = (ProgramData) CR2WTypeManager.Create("ProgramData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		public NetworkMinigameProgramController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

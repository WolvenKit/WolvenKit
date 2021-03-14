using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameBufferController : inkWidgetLogicController
	{
		private inkWidgetReference _bufferSlotsContainer;
		private CName _elementLibraryName;
		private CArray<wCHandle<NetworkMinigameElementController>> _slotList;
		private inkWidgetReference _blinker;
		private CInt32 _count;
		private CHandle<inkanimProxy> _animProxy;
		private inkanimPlaybackOptions _animOptions;
		private CHandle<inkanimDefinition> _alpha_fadein;
		private CFloat _currentAlpha;
		private CFloat _nextAlpha;

		[Ordinal(1)] 
		[RED("bufferSlotsContainer")] 
		public inkWidgetReference BufferSlotsContainer
		{
			get
			{
				if (_bufferSlotsContainer == null)
				{
					_bufferSlotsContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "bufferSlotsContainer", cr2w, this);
				}
				return _bufferSlotsContainer;
			}
			set
			{
				if (_bufferSlotsContainer == value)
				{
					return;
				}
				_bufferSlotsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("slotList")] 
		public CArray<wCHandle<NetworkMinigameElementController>> SlotList
		{
			get
			{
				if (_slotList == null)
				{
					_slotList = (CArray<wCHandle<NetworkMinigameElementController>>) CR2WTypeManager.Create("array:whandle:NetworkMinigameElementController", "slotList", cr2w, this);
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

		[Ordinal(4)] 
		[RED("blinker")] 
		public inkWidgetReference Blinker
		{
			get
			{
				if (_blinker == null)
				{
					_blinker = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "blinker", cr2w, this);
				}
				return _blinker;
			}
			set
			{
				if (_blinker == value)
				{
					return;
				}
				_blinker = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("count")] 
		public CInt32 Count
		{
			get
			{
				if (_count == null)
				{
					_count = (CInt32) CR2WTypeManager.Create("Int32", "count", cr2w, this);
				}
				return _count;
			}
			set
			{
				if (_count == value)
				{
					return;
				}
				_count = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("AnimProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "AnimProxy", cr2w, this);
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

		[Ordinal(7)] 
		[RED("AnimOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get
			{
				if (_animOptions == null)
				{
					_animOptions = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "AnimOptions", cr2w, this);
				}
				return _animOptions;
			}
			set
			{
				if (_animOptions == value)
				{
					return;
				}
				_animOptions = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("alpha_fadein")] 
		public CHandle<inkanimDefinition> Alpha_fadein
		{
			get
			{
				if (_alpha_fadein == null)
				{
					_alpha_fadein = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "alpha_fadein", cr2w, this);
				}
				return _alpha_fadein;
			}
			set
			{
				if (_alpha_fadein == value)
				{
					return;
				}
				_alpha_fadein = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("currentAlpha")] 
		public CFloat CurrentAlpha
		{
			get
			{
				if (_currentAlpha == null)
				{
					_currentAlpha = (CFloat) CR2WTypeManager.Create("Float", "currentAlpha", cr2w, this);
				}
				return _currentAlpha;
			}
			set
			{
				if (_currentAlpha == value)
				{
					return;
				}
				_currentAlpha = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("nextAlpha")] 
		public CFloat NextAlpha
		{
			get
			{
				if (_nextAlpha == null)
				{
					_nextAlpha = (CFloat) CR2WTypeManager.Create("Float", "nextAlpha", cr2w, this);
				}
				return _nextAlpha;
			}
			set
			{
				if (_nextAlpha == value)
				{
					return;
				}
				_nextAlpha = value;
				PropertySet(this);
			}
		}

		public NetworkMinigameBufferController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

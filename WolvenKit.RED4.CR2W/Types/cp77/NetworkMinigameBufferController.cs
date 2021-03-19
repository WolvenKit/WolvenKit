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
			get => GetProperty(ref _bufferSlotsContainer);
			set => SetProperty(ref _bufferSlotsContainer, value);
		}

		[Ordinal(2)] 
		[RED("elementLibraryName")] 
		public CName ElementLibraryName
		{
			get => GetProperty(ref _elementLibraryName);
			set => SetProperty(ref _elementLibraryName, value);
		}

		[Ordinal(3)] 
		[RED("slotList")] 
		public CArray<wCHandle<NetworkMinigameElementController>> SlotList
		{
			get => GetProperty(ref _slotList);
			set => SetProperty(ref _slotList, value);
		}

		[Ordinal(4)] 
		[RED("blinker")] 
		public inkWidgetReference Blinker
		{
			get => GetProperty(ref _blinker);
			set => SetProperty(ref _blinker, value);
		}

		[Ordinal(5)] 
		[RED("count")] 
		public CInt32 Count
		{
			get => GetProperty(ref _count);
			set => SetProperty(ref _count, value);
		}

		[Ordinal(6)] 
		[RED("AnimProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(7)] 
		[RED("AnimOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get => GetProperty(ref _animOptions);
			set => SetProperty(ref _animOptions, value);
		}

		[Ordinal(8)] 
		[RED("alpha_fadein")] 
		public CHandle<inkanimDefinition> Alpha_fadein
		{
			get => GetProperty(ref _alpha_fadein);
			set => SetProperty(ref _alpha_fadein, value);
		}

		[Ordinal(9)] 
		[RED("currentAlpha")] 
		public CFloat CurrentAlpha
		{
			get => GetProperty(ref _currentAlpha);
			set => SetProperty(ref _currentAlpha, value);
		}

		[Ordinal(10)] 
		[RED("nextAlpha")] 
		public CFloat NextAlpha
		{
			get => GetProperty(ref _nextAlpha);
			set => SetProperty(ref _nextAlpha, value);
		}

		public NetworkMinigameBufferController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

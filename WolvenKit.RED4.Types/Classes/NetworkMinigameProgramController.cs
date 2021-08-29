using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NetworkMinigameProgramController : inkWidgetLogicController
	{
		private inkTextWidgetReference _text;
		private CArray<inkWidgetReference> _commandElementSlotsContainer;
		private CName _elementLibraryName;
		private inkWidgetReference _completedMarker;
		private inkImageWidgetReference _imageRef;
		private CArray<CArray<CWeakHandle<NetworkMinigameElementController>>> _slotList;
		private ProgramData _data;
		private CHandle<inkanimProxy> _animProxy;

		[Ordinal(1)] 
		[RED("text")] 
		public inkTextWidgetReference Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(2)] 
		[RED("commandElementSlotsContainer")] 
		public CArray<inkWidgetReference> CommandElementSlotsContainer
		{
			get => GetProperty(ref _commandElementSlotsContainer);
			set => SetProperty(ref _commandElementSlotsContainer, value);
		}

		[Ordinal(3)] 
		[RED("elementLibraryName")] 
		public CName ElementLibraryName
		{
			get => GetProperty(ref _elementLibraryName);
			set => SetProperty(ref _elementLibraryName, value);
		}

		[Ordinal(4)] 
		[RED("completedMarker")] 
		public inkWidgetReference CompletedMarker
		{
			get => GetProperty(ref _completedMarker);
			set => SetProperty(ref _completedMarker, value);
		}

		[Ordinal(5)] 
		[RED("imageRef")] 
		public inkImageWidgetReference ImageRef
		{
			get => GetProperty(ref _imageRef);
			set => SetProperty(ref _imageRef, value);
		}

		[Ordinal(6)] 
		[RED("slotList")] 
		public CArray<CArray<CWeakHandle<NetworkMinigameElementController>>> SlotList
		{
			get => GetProperty(ref _slotList);
			set => SetProperty(ref _slotList, value);
		}

		[Ordinal(7)] 
		[RED("data")] 
		public ProgramData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(8)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}
	}
}

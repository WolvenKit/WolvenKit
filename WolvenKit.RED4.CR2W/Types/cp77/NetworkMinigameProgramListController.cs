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
			get => GetProperty(ref _programPlayerContainer);
			set => SetProperty(ref _programPlayerContainer, value);
		}

		[Ordinal(2)] 
		[RED("programNetworkContainer")] 
		public inkWidgetReference ProgramNetworkContainer
		{
			get => GetProperty(ref _programNetworkContainer);
			set => SetProperty(ref _programNetworkContainer, value);
		}

		[Ordinal(3)] 
		[RED("programLibraryName")] 
		public CName ProgramLibraryName
		{
			get => GetProperty(ref _programLibraryName);
			set => SetProperty(ref _programLibraryName, value);
		}

		[Ordinal(4)] 
		[RED("slotList")] 
		public CArray<wCHandle<NetworkMinigameProgramController>> SlotList
		{
			get => GetProperty(ref _slotList);
			set => SetProperty(ref _slotList, value);
		}

		[Ordinal(5)] 
		[RED("animProxy_02")] 
		public CHandle<inkanimProxy> AnimProxy_02
		{
			get => GetProperty(ref _animProxy_02);
			set => SetProperty(ref _animProxy_02, value);
		}

		[Ordinal(6)] 
		[RED("headerBG")] 
		public inkWidgetReference HeaderBG
		{
			get => GetProperty(ref _headerBG);
			set => SetProperty(ref _headerBG, value);
		}

		public NetworkMinigameProgramListController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

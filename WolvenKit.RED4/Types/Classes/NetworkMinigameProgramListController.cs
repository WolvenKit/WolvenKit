using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NetworkMinigameProgramListController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("programPlayerContainer")] 
		public inkWidgetReference ProgramPlayerContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("programNetworkContainer")] 
		public inkWidgetReference ProgramNetworkContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("programLibraryName")] 
		public CName ProgramLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("slotList")] 
		public CArray<CWeakHandle<NetworkMinigameProgramController>> SlotList
		{
			get => GetPropertyValue<CArray<CWeakHandle<NetworkMinigameProgramController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<NetworkMinigameProgramController>>>(value);
		}

		[Ordinal(5)] 
		[RED("animProxy_02")] 
		public CHandle<inkanimProxy> AnimProxy_02
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(6)] 
		[RED("headerBG")] 
		public inkWidgetReference HeaderBG
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public NetworkMinigameProgramListController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

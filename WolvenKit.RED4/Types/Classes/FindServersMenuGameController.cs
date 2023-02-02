using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FindServersMenuGameController : PreGameSubMenuGameController
	{
		[Ordinal(3)] 
		[RED("serversListCtrl")] 
		public CWeakHandle<inkListController> ServersListCtrl
		{
			get => GetPropertyValue<CWeakHandle<inkListController>>();
			set => SetPropertyValue<CWeakHandle<inkListController>>(value);
		}

		[Ordinal(4)] 
		[RED("NONE_CHOOSEN")] 
		public CInt32 NONE_CHOOSEN
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("curentlyChoosenServer")] 
		public CInt32 CurentlyChoosenServer
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("LANStatusLabel")] 
		public CWeakHandle<inkTextWidget> LANStatusLabel
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(7)] 
		[RED("WEBStatusLabel")] 
		public CWeakHandle<inkTextWidget> WEBStatusLabel
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(8)] 
		[RED("c_onlineColor")] 
		public CColor C_onlineColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(9)] 
		[RED("c_offlineColor")] 
		public CColor C_offlineColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(10)] 
		[RED("token")] 
		public CWeakHandle<inkTextWidget> Token
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		public FindServersMenuGameController()
		{
			NONE_CHOOSEN = -1;
			CurentlyChoosenServer = -1;
			C_onlineColor = new();
			C_offlineColor = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InteractionMappinController : gameuiInteractionMappinController
	{
		[Ordinal(11)] 
		[RED("mappin")] 
		public CWeakHandle<gamemappinsInteractionMappin> Mappin
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsInteractionMappin>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsInteractionMappin>>(value);
		}

		[Ordinal(12)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(13)] 
		[RED("isConnected")] 
		public CBool IsConnected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public InteractionMappinController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

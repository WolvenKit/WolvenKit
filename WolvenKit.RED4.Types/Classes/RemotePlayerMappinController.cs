using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RemotePlayerMappinController : gameuiInteractionMappinController
	{
		[Ordinal(11)] 
		[RED("mappin")] 
		public CWeakHandle<gamemappinsRemotePlayerMappin> Mappin
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsRemotePlayerMappin>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsRemotePlayerMappin>>(value);
		}

		[Ordinal(12)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RemotePlayerMappinController : gameuiInteractionMappinController
	{
		private CWeakHandle<gamemappinsRemotePlayerMappin> _mappin;
		private CWeakHandle<inkWidget> _root;

		[Ordinal(11)] 
		[RED("mappin")] 
		public CWeakHandle<gamemappinsRemotePlayerMappin> Mappin
		{
			get => GetProperty(ref _mappin);
			set => SetProperty(ref _mappin, value);
		}

		[Ordinal(12)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InteractionMappinController : gameuiInteractionMappinController
	{
		private CWeakHandle<gamemappinsInteractionMappin> _mappin;
		private CWeakHandle<inkWidget> _root;
		private CBool _isConnected;

		[Ordinal(11)] 
		[RED("mappin")] 
		public CWeakHandle<gamemappinsInteractionMappin> Mappin
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

		[Ordinal(13)] 
		[RED("isConnected")] 
		public CBool IsConnected
		{
			get => GetProperty(ref _isConnected);
			set => SetProperty(ref _isConnected, value);
		}
	}
}

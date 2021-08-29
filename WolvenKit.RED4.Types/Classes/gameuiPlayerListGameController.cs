using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiPlayerListGameController : gameuiHUDGameController
	{
		private CArray<PlayerListEntryData> _playerEntries;
		private inkCompoundWidgetReference _container;

		[Ordinal(9)] 
		[RED("playerEntries")] 
		public CArray<PlayerListEntryData> PlayerEntries
		{
			get => GetProperty(ref _playerEntries);
			set => SetProperty(ref _playerEntries, value);
		}

		[Ordinal(10)] 
		[RED("container")] 
		public inkCompoundWidgetReference Container
		{
			get => GetProperty(ref _container);
			set => SetProperty(ref _container, value);
		}
	}
}

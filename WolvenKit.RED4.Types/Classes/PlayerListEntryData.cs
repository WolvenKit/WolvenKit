using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerListEntryData : RedBaseClass
	{
		private CWeakHandle<gameObject> _playerObject;
		private CWeakHandle<inkWidget> _playerListEntry;

		[Ordinal(0)] 
		[RED("playerObject")] 
		public CWeakHandle<gameObject> PlayerObject
		{
			get => GetProperty(ref _playerObject);
			set => SetProperty(ref _playerObject, value);
		}

		[Ordinal(1)] 
		[RED("playerListEntry")] 
		public CWeakHandle<inkWidget> PlayerListEntry
		{
			get => GetProperty(ref _playerListEntry);
			set => SetProperty(ref _playerListEntry, value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workSyncAnimClip : workAnimClip
	{
		private CName _slotName;
		private Transform _syncOffset;

		[Ordinal(4)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(5)] 
		[RED("syncOffset")] 
		public Transform SyncOffset
		{
			get => GetProperty(ref _syncOffset);
			set => SetProperty(ref _syncOffset, value);
		}
	}
}

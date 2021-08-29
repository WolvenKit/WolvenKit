using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entMusicSyncEvent : redEvent
	{
		private CEnum<audioMusicSyncType> _syncType;
		private CFloat _syncParameter;

		[Ordinal(0)] 
		[RED("syncType")] 
		public CEnum<audioMusicSyncType> SyncType
		{
			get => GetProperty(ref _syncType);
			set => SetProperty(ref _syncType, value);
		}

		[Ordinal(1)] 
		[RED("syncParameter")] 
		public CFloat SyncParameter
		{
			get => GetProperty(ref _syncParameter);
			set => SetProperty(ref _syncParameter, value);
		}
	}
}

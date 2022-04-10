using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entMusicSyncEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("syncType")] 
		public CEnum<audioMusicSyncType> SyncType
		{
			get => GetPropertyValue<CEnum<audioMusicSyncType>>();
			set => SetPropertyValue<CEnum<audioMusicSyncType>>(value);
		}

		[Ordinal(1)] 
		[RED("syncParameter")] 
		public CFloat SyncParameter
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public entMusicSyncEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

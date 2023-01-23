using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questAudioMusicSyncNodeType : questIAudioNodeType
	{
		[Ordinal(0)] 
		[RED("syncType")] 
		public CEnum<audioMusicSyncType> SyncType
		{
			get => GetPropertyValue<CEnum<audioMusicSyncType>>();
			set => SetPropertyValue<CEnum<audioMusicSyncType>>(value);
		}

		[Ordinal(1)] 
		[RED("description")] 
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("syncTrack")] 
		public CName SyncTrack
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("userCue")] 
		public CName UserCue
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questAudioMusicSyncNodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

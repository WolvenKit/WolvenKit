using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamemappinsRemotePlayerMappin : gamemappinsRuntimeMappin
	{
		[Ordinal(0)] 
		[RED("hasMissionData")] 
		public CBool HasMissionData
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("vitals")] 
		public CInt32 Vitals
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gamemappinsRemotePlayerMappin()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

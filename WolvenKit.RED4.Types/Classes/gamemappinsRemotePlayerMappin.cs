using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamemappinsRemotePlayerMappin : gamemappinsRuntimeMappin
	{
		private CBool _hasMissionData;
		private CInt32 _vitals;

		[Ordinal(0)] 
		[RED("hasMissionData")] 
		public CBool HasMissionData
		{
			get => GetProperty(ref _hasMissionData);
			set => SetProperty(ref _hasMissionData, value);
		}

		[Ordinal(1)] 
		[RED("vitals")] 
		public CInt32 Vitals
		{
			get => GetProperty(ref _vitals);
			set => SetProperty(ref _vitals, value);
		}
	}
}

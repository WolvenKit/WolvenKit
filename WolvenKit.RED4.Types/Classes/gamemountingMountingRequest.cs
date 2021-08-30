using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamemountingMountingRequest : IScriptable
	{
		private gamemountingMountingInfo _lowLevelMountingInfo;
		private CBool _preservePositionAfterMounting;
		private CHandle<gameMountEventData> _mountData;

		[Ordinal(0)] 
		[RED("lowLevelMountingInfo")] 
		public gamemountingMountingInfo LowLevelMountingInfo
		{
			get => GetProperty(ref _lowLevelMountingInfo);
			set => SetProperty(ref _lowLevelMountingInfo, value);
		}

		[Ordinal(1)] 
		[RED("preservePositionAfterMounting")] 
		public CBool PreservePositionAfterMounting
		{
			get => GetProperty(ref _preservePositionAfterMounting);
			set => SetProperty(ref _preservePositionAfterMounting, value);
		}

		[Ordinal(2)] 
		[RED("mountData")] 
		public CHandle<gameMountEventData> MountData
		{
			get => GetProperty(ref _mountData);
			set => SetProperty(ref _mountData, value);
		}

		public gamemountingMountingRequest()
		{
			_preservePositionAfterMounting = true;
		}
	}
}

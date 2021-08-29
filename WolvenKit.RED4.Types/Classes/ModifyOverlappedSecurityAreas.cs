using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ModifyOverlappedSecurityAreas : redEvent
	{
		private CBool _isEntering;
		private gamePersistentID _zoneID;

		[Ordinal(0)] 
		[RED("isEntering")] 
		public CBool IsEntering
		{
			get => GetProperty(ref _isEntering);
			set => SetProperty(ref _isEntering, value);
		}

		[Ordinal(1)] 
		[RED("zoneID")] 
		public gamePersistentID ZoneID
		{
			get => GetProperty(ref _zoneID);
			set => SetProperty(ref _zoneID, value);
		}
	}
}

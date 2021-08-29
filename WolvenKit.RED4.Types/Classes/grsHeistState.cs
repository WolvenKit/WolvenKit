using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class grsHeistState : RedBaseClass
	{
		private netTime _time;
		private CEnum<grsHeistStatus> _status;
		private CStatic<grsHeistPlayerGameInfo> _playersInfo;

		[Ordinal(0)] 
		[RED("time")] 
		public netTime Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		[Ordinal(1)] 
		[RED("status")] 
		public CEnum<grsHeistStatus> Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}

		[Ordinal(2)] 
		[RED("playersInfo", 7)] 
		public CStatic<grsHeistPlayerGameInfo> PlayersInfo
		{
			get => GetProperty(ref _playersInfo);
			set => SetProperty(ref _playersInfo, value);
		}
	}
}

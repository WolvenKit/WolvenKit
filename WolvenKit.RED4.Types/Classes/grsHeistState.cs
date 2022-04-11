using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class grsHeistState : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("time")] 
		public netTime Time
		{
			get => GetPropertyValue<netTime>();
			set => SetPropertyValue<netTime>(value);
		}

		[Ordinal(1)] 
		[RED("status")] 
		public CEnum<grsHeistStatus> Status
		{
			get => GetPropertyValue<CEnum<grsHeistStatus>>();
			set => SetPropertyValue<CEnum<grsHeistStatus>>(value);
		}

		[Ordinal(2)] 
		[RED("playersInfo", 7)] 
		public CStatic<grsHeistPlayerGameInfo> PlayersInfo
		{
			get => GetPropertyValue<CStatic<grsHeistPlayerGameInfo>>();
			set => SetPropertyValue<CStatic<grsHeistPlayerGameInfo>>(value);
		}

		public grsHeistState()
		{
			Time = new();
			PlayersInfo = new(0);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

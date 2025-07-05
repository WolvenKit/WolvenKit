using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class grsDeathmatchState : RedBaseClass
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
		public CEnum<grsDeathmatchStatus> Status
		{
			get => GetPropertyValue<CEnum<grsDeathmatchStatus>>();
			set => SetPropertyValue<CEnum<grsDeathmatchStatus>>(value);
		}

		[Ordinal(2)] 
		[RED("sessionLength")] 
		public netTime SessionLength
		{
			get => GetPropertyValue<netTime>();
			set => SetPropertyValue<netTime>(value);
		}

		[Ordinal(3)] 
		[RED("playersInfo", 7)] 
		public CStatic<grsDeathmatchPlayerGameInfo> PlayersInfo
		{
			get => GetPropertyValue<CStatic<grsDeathmatchPlayerGameInfo>>();
			set => SetPropertyValue<CStatic<grsDeathmatchPlayerGameInfo>>(value);
		}

		public grsDeathmatchState()
		{
			Time = new netTime();
			SessionLength = new netTime();
			PlayersInfo = new(0);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

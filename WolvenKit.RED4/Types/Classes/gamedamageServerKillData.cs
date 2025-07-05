using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamedamageServerKillData : IScriptable
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("killInfo")] 
		public gameuiKillInfo KillInfo
		{
			get => GetPropertyValue<gameuiKillInfo>();
			set => SetPropertyValue<gameuiKillInfo>(value);
		}

		public gamedamageServerKillData()
		{
			KillInfo = new gameuiKillInfo();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

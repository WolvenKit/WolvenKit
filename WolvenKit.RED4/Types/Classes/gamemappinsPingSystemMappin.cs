using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamemappinsPingSystemMappin : gamemappinsRuntimeMappin
	{
		[Ordinal(0)] 
		[RED("pingType")] 
		public CEnum<gamedataPingType> PingType
		{
			get => GetPropertyValue<CEnum<gamedataPingType>>();
			set => SetPropertyValue<CEnum<gamedataPingType>>(value);
		}

		public gamemappinsPingSystemMappin()
		{
			PingType = Enums.gamedataPingType.Invalid;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

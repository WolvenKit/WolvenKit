using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamemappinsPingSystemMappin : gamemappinsRuntimeMappin
	{
		private CEnum<gamedataPingType> _pingType;

		[Ordinal(0)] 
		[RED("pingType")] 
		public CEnum<gamedataPingType> PingType
		{
			get => GetProperty(ref _pingType);
			set => SetProperty(ref _pingType, value);
		}

		public gamemappinsPingSystemMappin()
		{
			_pingType = new() { Value = Enums.gamedataPingType.Invalid };
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActivePerkChangedEvent : redEvent
	{
		private CEnum<gamedataPerkArea> _perkArea;
		private CEnum<gamedataPerkType> _perkType;

		[Ordinal(0)] 
		[RED("perkArea")] 
		public CEnum<gamedataPerkArea> PerkArea
		{
			get => GetProperty(ref _perkArea);
			set => SetProperty(ref _perkArea, value);
		}

		[Ordinal(1)] 
		[RED("perkType")] 
		public CEnum<gamedataPerkType> PerkType
		{
			get => GetProperty(ref _perkType);
			set => SetProperty(ref _perkType, value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PerkPrereq : gameIScriptablePrereq
	{
		private CEnum<gamedataPerkType> _perk;

		[Ordinal(0)] 
		[RED("perk")] 
		public CEnum<gamedataPerkType> Perk
		{
			get => GetProperty(ref _perk);
			set => SetProperty(ref _perk, value);
		}
	}
}

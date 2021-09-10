using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PerkPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("perk")] 
		public CEnum<gamedataPerkType> Perk
		{
			get => GetPropertyValue<CEnum<gamedataPerkType>>();
			set => SetPropertyValue<CEnum<gamedataPerkType>>(value);
		}
	}
}

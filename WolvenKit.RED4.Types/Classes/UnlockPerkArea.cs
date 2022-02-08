using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UnlockPerkArea : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("perkArea")] 
		public CEnum<gamedataPerkArea> PerkArea
		{
			get => GetPropertyValue<CEnum<gamedataPerkArea>>();
			set => SetPropertyValue<CEnum<gamedataPerkArea>>(value);
		}
	}
}

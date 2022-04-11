using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RemovePerk : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("perkType")] 
		public CEnum<gamedataPerkType> PerkType
		{
			get => GetPropertyValue<CEnum<gamedataPerkType>>();
			set => SetPropertyValue<CEnum<gamedataPerkType>>(value);
		}
	}
}

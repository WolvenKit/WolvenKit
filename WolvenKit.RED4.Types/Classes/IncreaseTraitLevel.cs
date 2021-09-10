using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IncreaseTraitLevel : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("trait")] 
		public CEnum<gamedataTraitType> Trait
		{
			get => GetPropertyValue<CEnum<gamedataTraitType>>();
			set => SetPropertyValue<CEnum<gamedataTraitType>>(value);
		}
	}
}

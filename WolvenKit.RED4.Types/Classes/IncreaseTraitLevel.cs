using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IncreaseTraitLevel : gamePlayerScriptableSystemRequest
	{
		private CEnum<gamedataTraitType> _trait;

		[Ordinal(1)] 
		[RED("trait")] 
		public CEnum<gamedataTraitType> Trait
		{
			get => GetProperty(ref _trait);
			set => SetProperty(ref _trait, value);
		}
	}
}

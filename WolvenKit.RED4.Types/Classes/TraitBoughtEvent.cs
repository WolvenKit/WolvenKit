using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TraitBoughtEvent : redEvent
	{
		private CEnum<gamedataTraitType> _traitType;

		[Ordinal(0)] 
		[RED("traitType")] 
		public CEnum<gamedataTraitType> TraitType
		{
			get => GetProperty(ref _traitType);
			set => SetProperty(ref _traitType, value);
		}
	}
}

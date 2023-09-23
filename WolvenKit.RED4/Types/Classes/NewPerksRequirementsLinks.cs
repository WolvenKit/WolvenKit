using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerksRequirementsLinks : IScriptable
	{
		[Ordinal(0)] 
		[RED("perk")] 
		public CEnum<gamedataNewPerkType> Perk
		{
			get => GetPropertyValue<CEnum<gamedataNewPerkType>>();
			set => SetPropertyValue<CEnum<gamedataNewPerkType>>(value);
		}

		[Ordinal(1)] 
		[RED("linkedPerks")] 
		public CArray<CEnum<gamedataNewPerkType>> LinkedPerks
		{
			get => GetPropertyValue<CArray<CEnum<gamedataNewPerkType>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataNewPerkType>>>(value);
		}

		public NewPerksRequirementsLinks()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

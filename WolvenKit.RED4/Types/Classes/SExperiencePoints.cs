using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SExperiencePoints : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("amount")] 
		public CFloat Amount
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("forType")] 
		public CEnum<gamedataProficiencyType> ForType
		{
			get => GetPropertyValue<CEnum<gamedataProficiencyType>>();
			set => SetPropertyValue<CEnum<gamedataProficiencyType>>(value);
		}

		[Ordinal(2)] 
		[RED("entity")] 
		public entEntityID Entity
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public SExperiencePoints()
		{
			Entity = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

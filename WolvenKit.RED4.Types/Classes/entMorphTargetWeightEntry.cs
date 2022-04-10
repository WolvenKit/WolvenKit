using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entMorphTargetWeightEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("targetName")] 
		public CName TargetName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("regionName")] 
		public CName RegionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public entMorphTargetWeightEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

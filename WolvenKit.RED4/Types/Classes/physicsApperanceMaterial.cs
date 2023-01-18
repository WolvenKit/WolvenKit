using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsApperanceMaterial : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("apperanceName")] 
		public CName ApperanceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("materialFrom")] 
		public CName MaterialFrom
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("material")] 
		public CName Material
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public physicsApperanceMaterial()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entdismembermentWoundConfigContainer : ISerializable
	{
		[Ordinal(0)] 
		[RED("AppearanceName")] 
		public CName AppearanceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("Wounds")] 
		public CArray<entdismembermentWoundConfig> Wounds
		{
			get => GetPropertyValue<CArray<entdismembermentWoundConfig>>();
			set => SetPropertyValue<CArray<entdismembermentWoundConfig>>(value);
		}

		public entdismembermentWoundConfigContainer()
		{
			Wounds = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

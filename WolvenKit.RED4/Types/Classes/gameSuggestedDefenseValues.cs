using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSuggestedDefenseValues : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("minArmor")] 
		public CFloat MinArmor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("maxArmor")] 
		public CFloat MaxArmor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("minProtection")] 
		public CFloat MinProtection
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("maxProtection")] 
		public CFloat MaxProtection
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameSuggestedDefenseValues()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

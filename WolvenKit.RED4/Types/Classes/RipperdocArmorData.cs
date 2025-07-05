using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocArmorData : IScriptable
	{
		[Ordinal(0)] 
		[RED("CurrentArmor")] 
		public CFloat CurrentArmor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("CurrentMaxArmor")] 
		public CFloat CurrentMaxArmor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("MaxArmorPossible")] 
		public CFloat MaxArmorPossible
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("MaxDamageReduction")] 
		public CFloat MaxDamageReduction
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public RipperdocArmorData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

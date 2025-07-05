using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EffectFiringData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("FXTime")] 
		public CFloat FXTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("VFX")] 
		public CName VFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("SFX")] 
		public CName SFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public EffectFiringData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

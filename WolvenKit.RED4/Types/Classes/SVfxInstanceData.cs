using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SVfxInstanceData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("fx")] 
		public CHandle<gameFxInstance> Fx
		{
			get => GetPropertyValue<CHandle<gameFxInstance>>();
			set => SetPropertyValue<CHandle<gameFxInstance>>(value);
		}

		[Ordinal(1)] 
		[RED("id")] 
		public CName Id
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SVfxInstanceData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

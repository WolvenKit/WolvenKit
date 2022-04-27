using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VentilationAreaSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("areaEffect")] 
		public CEnum<ETrapEffects> AreaEffect
		{
			get => GetPropertyValue<CEnum<ETrapEffects>>();
			set => SetPropertyValue<CEnum<ETrapEffects>>(value);
		}

		[Ordinal(1)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public VentilationAreaSetup()
		{
			ActionName = "Activate";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

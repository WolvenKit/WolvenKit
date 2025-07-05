using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetControllersSnapshot : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("controllers")] 
		public CArray<gameMuppetControllerSnapshot> Controllers
		{
			get => GetPropertyValue<CArray<gameMuppetControllerSnapshot>>();
			set => SetPropertyValue<CArray<gameMuppetControllerSnapshot>>(value);
		}

		public gameMuppetControllersSnapshot()
		{
			Controllers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

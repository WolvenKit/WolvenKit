using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetControllersSnapshot : RedBaseClass
	{
		private CArray<gameMuppetControllerSnapshot> _controllers;

		[Ordinal(0)] 
		[RED("controllers")] 
		public CArray<gameMuppetControllerSnapshot> Controllers
		{
			get => GetProperty(ref _controllers);
			set => SetProperty(ref _controllers, value);
		}
	}
}

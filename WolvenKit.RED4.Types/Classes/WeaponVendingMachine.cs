using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeaponVendingMachine : VendingMachine
	{
		private CWeakHandle<IWorldWidgetComponent> _bigAdScreen;

		[Ordinal(101)] 
		[RED("bigAdScreen")] 
		public CWeakHandle<IWorldWidgetComponent> BigAdScreen
		{
			get => GetProperty(ref _bigAdScreen);
			set => SetProperty(ref _bigAdScreen, value);
		}
	}
}

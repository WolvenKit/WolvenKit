using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CrosshairModule : HUDModule
	{
		private CArray<CHandle<Crosshair>> _activeCrosshairs;

		[Ordinal(3)] 
		[RED("activeCrosshairs")] 
		public CArray<CHandle<Crosshair>> ActiveCrosshairs
		{
			get => GetProperty(ref _activeCrosshairs);
			set => SetProperty(ref _activeCrosshairs, value);
		}
	}
}

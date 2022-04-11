using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CrosshairModule : HUDModule
	{
		[Ordinal(3)] 
		[RED("activeCrosshairs")] 
		public CArray<CHandle<Crosshair>> ActiveCrosshairs
		{
			get => GetPropertyValue<CArray<CHandle<Crosshair>>>();
			set => SetPropertyValue<CArray<CHandle<Crosshair>>>(value);
		}

		public CrosshairModule()
		{
			InstancesList = new();
			ActiveCrosshairs = new();
		}
	}
}

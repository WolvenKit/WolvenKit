using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HoloFeeder : Device
	{
		[Ordinal(84)] 
		[RED("feederMesh")] 
		public CHandle<entIPlacedComponent> FeederMesh
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		public HoloFeeder()
		{
			ControllerTypeName = "HoloFeederController";
		}
	}
}

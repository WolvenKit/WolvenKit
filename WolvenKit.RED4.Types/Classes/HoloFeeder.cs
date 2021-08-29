using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HoloFeeder : Device
	{
		private CHandle<entIPlacedComponent> _feederMesh;

		[Ordinal(87)] 
		[RED("feederMesh")] 
		public CHandle<entIPlacedComponent> FeederMesh
		{
			get => GetProperty(ref _feederMesh);
			set => SetProperty(ref _feederMesh, value);
		}
	}
}

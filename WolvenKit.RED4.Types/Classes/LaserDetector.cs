using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LaserDetector : ProximityDetector
	{
		[Ordinal(93)] 
		[RED("lasers", 2)] 
		public CArrayFixedSize<CHandle<entMeshComponent>> Lasers
		{
			get => GetPropertyValue<CArrayFixedSize<CHandle<entMeshComponent>>>();
			set => SetPropertyValue<CArrayFixedSize<CHandle<entMeshComponent>>>(value);
		}

		public LaserDetector()
		{
			ControllerTypeName = "LaserDetectorController";
			ScanningAreaName = "scanningArea";
			SurroundingAreaName = "surroundingArea";
			Lasers = new(2);
		}
	}
}

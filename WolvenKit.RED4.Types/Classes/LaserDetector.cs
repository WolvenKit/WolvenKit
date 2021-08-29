using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LaserDetector : ProximityDetector
	{
		private CArrayFixedSize<CHandle<entMeshComponent>> _lasers;

		[Ordinal(93)] 
		[RED("lasers", 2)] 
		public CArrayFixedSize<CHandle<entMeshComponent>> Lasers
		{
			get => GetProperty(ref _lasers);
			set => SetProperty(ref _lasers, value);
		}
	}
}

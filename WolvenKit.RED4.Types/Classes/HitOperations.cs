using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitOperations : DeviceOperations
	{
		private CArray<SHitOperationData> _hitOperations;

		[Ordinal(2)] 
		[RED("hitOperations")] 
		public CArray<SHitOperationData> HitOperations_
		{
			get => GetProperty(ref _hitOperations);
			set => SetProperty(ref _hitOperations, value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HitOperations : DeviceOperations
	{
		[Ordinal(2)] 
		[RED("hitOperations")] 
		public CArray<SHitOperationData> HitOperations_
		{
			get => GetPropertyValue<CArray<SHitOperationData>>();
			set => SetPropertyValue<CArray<SHitOperationData>>(value);
		}

		public HitOperations()
		{
			Components = new();
			FxInstances = new();
			HitOperations_ = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

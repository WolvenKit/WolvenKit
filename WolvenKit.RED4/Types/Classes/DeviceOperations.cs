using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceOperations : IScriptable
	{
		[Ordinal(0)] 
		[RED("components")] 
		public CArray<CWeakHandle<entIPlacedComponent>> Components
		{
			get => GetPropertyValue<CArray<CWeakHandle<entIPlacedComponent>>>();
			set => SetPropertyValue<CArray<CWeakHandle<entIPlacedComponent>>>(value);
		}

		[Ordinal(1)] 
		[RED("fxInstances")] 
		public CArray<SVfxInstanceData> FxInstances
		{
			get => GetPropertyValue<CArray<SVfxInstanceData>>();
			set => SetPropertyValue<CArray<SVfxInstanceData>>(value);
		}

		public DeviceOperations()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

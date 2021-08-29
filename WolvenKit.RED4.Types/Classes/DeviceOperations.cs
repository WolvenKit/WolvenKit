using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceOperations : IScriptable
	{
		private CArray<CWeakHandle<entIPlacedComponent>> _components;
		private CArray<SVfxInstanceData> _fxInstances;

		[Ordinal(0)] 
		[RED("components")] 
		public CArray<CWeakHandle<entIPlacedComponent>> Components
		{
			get => GetProperty(ref _components);
			set => SetProperty(ref _components, value);
		}

		[Ordinal(1)] 
		[RED("fxInstances")] 
		public CArray<SVfxInstanceData> FxInstances
		{
			get => GetProperty(ref _fxInstances);
			set => SetProperty(ref _fxInstances, value);
		}
	}
}

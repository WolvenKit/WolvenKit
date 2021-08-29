using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayEffectDeviceOperation : DeviceOperationBase
	{
		private CArray<SVFXOperationData> _vFXs;
		private CArray<SVfxInstanceData> _fxInstances;

		[Ordinal(5)] 
		[RED("VFXs")] 
		public CArray<SVFXOperationData> VFXs
		{
			get => GetProperty(ref _vFXs);
			set => SetProperty(ref _vFXs, value);
		}

		[Ordinal(6)] 
		[RED("fxInstances")] 
		public CArray<SVfxInstanceData> FxInstances
		{
			get => GetProperty(ref _fxInstances);
			set => SetProperty(ref _fxInstances, value);
		}
	}
}

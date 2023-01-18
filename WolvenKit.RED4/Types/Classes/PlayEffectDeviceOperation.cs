using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayEffectDeviceOperation : DeviceOperationBase
	{
		[Ordinal(5)] 
		[RED("VFXs")] 
		public CArray<SVFXOperationData> VFXs
		{
			get => GetPropertyValue<CArray<SVFXOperationData>>();
			set => SetPropertyValue<CArray<SVFXOperationData>>(value);
		}

		[Ordinal(6)] 
		[RED("fxInstances")] 
		public CArray<SVfxInstanceData> FxInstances
		{
			get => GetPropertyValue<CArray<SVfxInstanceData>>();
			set => SetPropertyValue<CArray<SVfxInstanceData>>(value);
		}

		public PlayEffectDeviceOperation()
		{
			IsEnabled = true;
			ToggleOperations = new();
			VFXs = new();
			FxInstances = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

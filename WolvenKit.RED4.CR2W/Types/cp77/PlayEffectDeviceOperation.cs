using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayEffectDeviceOperation : DeviceOperationBase
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

		public PlayEffectDeviceOperation(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

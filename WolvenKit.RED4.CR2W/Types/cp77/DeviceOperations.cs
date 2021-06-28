using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceOperations : IScriptable
	{
		private CArray<wCHandle<entIPlacedComponent>> _components;
		private CArray<SVfxInstanceData> _fxInstances;

		[Ordinal(0)] 
		[RED("components")] 
		public CArray<wCHandle<entIPlacedComponent>> Components
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

		public DeviceOperations(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

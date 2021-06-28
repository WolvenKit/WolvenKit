using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericDevice : InteractiveDevice
	{
		private CHandle<AIOffMeshConnectionComponent> _offMeshConnectionComponent;
		private CHandle<CustomDeviceAction> _currentSpiderbotAction;

		[Ordinal(96)] 
		[RED("offMeshConnectionComponent")] 
		public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionComponent
		{
			get => GetProperty(ref _offMeshConnectionComponent);
			set => SetProperty(ref _offMeshConnectionComponent, value);
		}

		[Ordinal(97)] 
		[RED("currentSpiderbotAction")] 
		public CHandle<CustomDeviceAction> CurrentSpiderbotAction
		{
			get => GetProperty(ref _currentSpiderbotAction);
			set => SetProperty(ref _currentSpiderbotAction, value);
		}

		public GenericDevice(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

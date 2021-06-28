using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CustomActionOperations : DeviceOperations
	{
		private SCustomDeviceActionsData _customActions;
		private CArray<SCustomActionOperationData> _customActionsOperations;

		[Ordinal(2)] 
		[RED("customActions")] 
		public SCustomDeviceActionsData CustomActions
		{
			get => GetProperty(ref _customActions);
			set => SetProperty(ref _customActions, value);
		}

		[Ordinal(3)] 
		[RED("customActionsOperations")] 
		public CArray<SCustomActionOperationData> CustomActionsOperations
		{
			get => GetProperty(ref _customActionsOperations);
			set => SetProperty(ref _customActionsOperations, value);
		}

		public CustomActionOperations(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

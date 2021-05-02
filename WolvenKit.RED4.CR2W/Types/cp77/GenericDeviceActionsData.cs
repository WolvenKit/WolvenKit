using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericDeviceActionsData : CVariable
	{
		private SGenericDeviceActionsData _stateActionsOverrides;
		private SCustomDeviceActionsData _customActions;

		[Ordinal(0)] 
		[RED("stateActionsOverrides")] 
		public SGenericDeviceActionsData StateActionsOverrides
		{
			get => GetProperty(ref _stateActionsOverrides);
			set => SetProperty(ref _stateActionsOverrides, value);
		}

		[Ordinal(1)] 
		[RED("customActions")] 
		public SCustomDeviceActionsData CustomActions
		{
			get => GetProperty(ref _customActions);
			set => SetProperty(ref _customActions, value);
		}

		public GenericDeviceActionsData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

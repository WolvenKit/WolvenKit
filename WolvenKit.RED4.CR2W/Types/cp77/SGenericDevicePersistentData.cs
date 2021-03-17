using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SGenericDevicePersistentData : CVariable
	{
		private SGenericDeviceActionsData _genericActions;
		private SCustomDeviceActionsData _customActions;

		[Ordinal(0)] 
		[RED("genericActions")] 
		public SGenericDeviceActionsData GenericActions
		{
			get => GetProperty(ref _genericActions);
			set => SetProperty(ref _genericActions, value);
		}

		[Ordinal(1)] 
		[RED("customActions")] 
		public SCustomDeviceActionsData CustomActions
		{
			get => GetProperty(ref _customActions);
			set => SetProperty(ref _customActions, value);
		}

		public SGenericDevicePersistentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

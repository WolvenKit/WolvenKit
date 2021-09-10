using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityAlarm : InteractiveMasterDevice
	{
		[Ordinal(97)] 
		[RED("workingAlarm")] 
		public CHandle<entMeshComponent> WorkingAlarm
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(98)] 
		[RED("destroyedAlarm")] 
		public CHandle<entMeshComponent> DestroyedAlarm
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(99)] 
		[RED("isGlitching")] 
		public CBool IsGlitching
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SecurityAlarm()
		{
			ControllerTypeName = "SecurityAlarmController";
		}
	}
}

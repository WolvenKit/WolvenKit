using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityAlarm : InteractiveMasterDevice
	{
		[Ordinal(94)] 
		[RED("workingAlarm")] 
		public CHandle<entMeshComponent> WorkingAlarm
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(95)] 
		[RED("destroyedAlarm")] 
		public CHandle<entMeshComponent> DestroyedAlarm
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(96)] 
		[RED("isGlitching")] 
		public CBool IsGlitching
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SecurityAlarm()
		{
			ControllerTypeName = "SecurityAlarmController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

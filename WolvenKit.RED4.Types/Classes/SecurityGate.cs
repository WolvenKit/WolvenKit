using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityGate : InteractiveMasterDevice
	{
		[Ordinal(94)] 
		[RED("sideA")] 
		public CHandle<gameStaticTriggerAreaComponent> SideA
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(95)] 
		[RED("sideB")] 
		public CHandle<gameStaticTriggerAreaComponent> SideB
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(96)] 
		[RED("scanningArea")] 
		public CHandle<gameStaticTriggerAreaComponent> ScanningArea
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(97)] 
		[RED("trespassersDataList")] 
		public CArray<TrespasserEntry> TrespassersDataList
		{
			get => GetPropertyValue<CArray<TrespasserEntry>>();
			set => SetPropertyValue<CArray<TrespasserEntry>>(value);
		}

		public SecurityGate()
		{
			ControllerTypeName = "SecurityGateController";
			TrespassersDataList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnPlayDefaultMountedSlotWorkspotEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(7)] 
		[RED("parentRef")] 
		public gameEntityReference ParentRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(8)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("puppetVehicleState")] 
		public CEnum<scnPuppetVehicleState> PuppetVehicleState
		{
			get => GetPropertyValue<CEnum<scnPuppetVehicleState>>();
			set => SetPropertyValue<CEnum<scnPuppetVehicleState>>(value);
		}

		public scnPlayDefaultMountedSlotWorkspotEvent()
		{
			Id = new() { Id = 18446744073709551615 };
			Performer = new() { Id = 4294967040 };
			ParentRef = new() { Names = new() };
		}
	}
}

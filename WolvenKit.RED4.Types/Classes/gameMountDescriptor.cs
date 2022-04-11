using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMountDescriptor : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("parentId")] 
		public entEntityID ParentId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("initialTransform")] 
		public Transform InitialTransform
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(3)] 
		[RED("state")] 
		public CEnum<gamePuppetVehicleState> State
		{
			get => GetPropertyValue<CEnum<gamePuppetVehicleState>>();
			set => SetPropertyValue<CEnum<gamePuppetVehicleState>>(value);
		}

		[Ordinal(4)] 
		[RED("mountType")] 
		public CEnum<gameMountDescriptorMountType> MountType
		{
			get => GetPropertyValue<CEnum<gameMountDescriptorMountType>>();
			set => SetPropertyValue<CEnum<gameMountDescriptorMountType>>(value);
		}

		public gameMountDescriptor()
		{
			ParentId = new();
			InitialTransform = new() { Position = new(), Orientation = new() { R = 1.000000F } };
			MountType = Enums.gameMountDescriptorMountType.KeepState;
		}
	}
}

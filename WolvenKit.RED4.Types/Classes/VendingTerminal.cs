using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VendingTerminal : InteractiveDevice
	{
		[Ordinal(94)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(95)] 
		[RED("canMeshComponent")] 
		public CHandle<entMeshComponent> CanMeshComponent
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(96)] 
		[RED("vendingBlacklist")] 
		public CArray<CEnum<EVendorMode>> VendingBlacklist
		{
			get => GetPropertyValue<CArray<CEnum<EVendorMode>>>();
			set => SetPropertyValue<CArray<CEnum<EVendorMode>>>(value);
		}

		public VendingTerminal()
		{
			ControllerTypeName = "VendingTerminalController";
			Position = new();
			VendingBlacklist = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

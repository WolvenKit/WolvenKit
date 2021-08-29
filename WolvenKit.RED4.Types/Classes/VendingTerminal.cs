using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendingTerminal : InteractiveDevice
	{
		private Vector4 _position;
		private CHandle<entMeshComponent> _canMeshComponent;
		private CArray<CEnum<EVendorMode>> _vendingBlacklist;

		[Ordinal(97)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(98)] 
		[RED("canMeshComponent")] 
		public CHandle<entMeshComponent> CanMeshComponent
		{
			get => GetProperty(ref _canMeshComponent);
			set => SetProperty(ref _canMeshComponent, value);
		}

		[Ordinal(99)] 
		[RED("vendingBlacklist")] 
		public CArray<CEnum<EVendorMode>> VendingBlacklist
		{
			get => GetProperty(ref _vendingBlacklist);
			set => SetProperty(ref _vendingBlacklist, value);
		}
	}
}

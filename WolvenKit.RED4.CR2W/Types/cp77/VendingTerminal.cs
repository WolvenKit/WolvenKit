using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendingTerminal : InteractiveDevice
	{
		private Vector4 _position;
		private CHandle<entMeshComponent> _canMeshComponent;
		private CArray<CEnum<EVendorMode>> _vendingBlacklist;

		[Ordinal(96)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(97)] 
		[RED("canMeshComponent")] 
		public CHandle<entMeshComponent> CanMeshComponent
		{
			get => GetProperty(ref _canMeshComponent);
			set => SetProperty(ref _canMeshComponent, value);
		}

		[Ordinal(98)] 
		[RED("vendingBlacklist")] 
		public CArray<CEnum<EVendorMode>> VendingBlacklist
		{
			get => GetProperty(ref _vendingBlacklist);
			set => SetProperty(ref _vendingBlacklist, value);
		}

		public VendingTerminal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

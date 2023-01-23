using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VirtualItem_TEMP : gameObject
	{
		[Ordinal(35)] 
		[RED("item")] 
		public CString Item
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(36)] 
		[RED("interaction")] 
		public CHandle<gameinteractionsComponent> Interaction
		{
			get => GetPropertyValue<CHandle<gameinteractionsComponent>>();
			set => SetPropertyValue<CHandle<gameinteractionsComponent>>(value);
		}

		[Ordinal(37)] 
		[RED("mesh")] 
		public CHandle<entPhysicalMeshComponent> Mesh
		{
			get => GetPropertyValue<CHandle<entPhysicalMeshComponent>>();
			set => SetPropertyValue<CHandle<entPhysicalMeshComponent>>(value);
		}

		[Ordinal(38)] 
		[RED("mesh1")] 
		public CHandle<entPhysicalMeshComponent> Mesh1
		{
			get => GetPropertyValue<CHandle<entPhysicalMeshComponent>>();
			set => SetPropertyValue<CHandle<entPhysicalMeshComponent>>(value);
		}

		[Ordinal(39)] 
		[RED("mesh2")] 
		public CHandle<entPhysicalMeshComponent> Mesh2
		{
			get => GetPropertyValue<CHandle<entPhysicalMeshComponent>>();
			set => SetPropertyValue<CHandle<entPhysicalMeshComponent>>(value);
		}

		[Ordinal(40)] 
		[RED("mesh3")] 
		public CHandle<entPhysicalMeshComponent> Mesh3
		{
			get => GetPropertyValue<CHandle<entPhysicalMeshComponent>>();
			set => SetPropertyValue<CHandle<entPhysicalMeshComponent>>(value);
		}

		[Ordinal(41)] 
		[RED("mesh4")] 
		public CHandle<entPhysicalMeshComponent> Mesh4
		{
			get => GetPropertyValue<CHandle<entPhysicalMeshComponent>>();
			set => SetPropertyValue<CHandle<entPhysicalMeshComponent>>(value);
		}

		public VirtualItem_TEMP()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

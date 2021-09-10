using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VirtualItem_TEMP : gameObject
	{
		[Ordinal(40)] 
		[RED("item")] 
		public CString Item
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(41)] 
		[RED("interaction")] 
		public CHandle<gameinteractionsComponent> Interaction
		{
			get => GetPropertyValue<CHandle<gameinteractionsComponent>>();
			set => SetPropertyValue<CHandle<gameinteractionsComponent>>(value);
		}

		[Ordinal(42)] 
		[RED("mesh")] 
		public CHandle<entPhysicalMeshComponent> Mesh
		{
			get => GetPropertyValue<CHandle<entPhysicalMeshComponent>>();
			set => SetPropertyValue<CHandle<entPhysicalMeshComponent>>(value);
		}

		[Ordinal(43)] 
		[RED("mesh1")] 
		public CHandle<entPhysicalMeshComponent> Mesh1
		{
			get => GetPropertyValue<CHandle<entPhysicalMeshComponent>>();
			set => SetPropertyValue<CHandle<entPhysicalMeshComponent>>(value);
		}

		[Ordinal(44)] 
		[RED("mesh2")] 
		public CHandle<entPhysicalMeshComponent> Mesh2
		{
			get => GetPropertyValue<CHandle<entPhysicalMeshComponent>>();
			set => SetPropertyValue<CHandle<entPhysicalMeshComponent>>(value);
		}

		[Ordinal(45)] 
		[RED("mesh3")] 
		public CHandle<entPhysicalMeshComponent> Mesh3
		{
			get => GetPropertyValue<CHandle<entPhysicalMeshComponent>>();
			set => SetPropertyValue<CHandle<entPhysicalMeshComponent>>(value);
		}

		[Ordinal(46)] 
		[RED("mesh4")] 
		public CHandle<entPhysicalMeshComponent> Mesh4
		{
			get => GetPropertyValue<CHandle<entPhysicalMeshComponent>>();
			set => SetPropertyValue<CHandle<entPhysicalMeshComponent>>(value);
		}
	}
}

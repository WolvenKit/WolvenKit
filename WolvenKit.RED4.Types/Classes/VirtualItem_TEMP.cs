using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VirtualItem_TEMP : gameObject
	{
		private CString _item;
		private CHandle<gameinteractionsComponent> _interaction;
		private CHandle<entPhysicalMeshComponent> _mesh;
		private CHandle<entPhysicalMeshComponent> _mesh1;
		private CHandle<entPhysicalMeshComponent> _mesh2;
		private CHandle<entPhysicalMeshComponent> _mesh3;
		private CHandle<entPhysicalMeshComponent> _mesh4;

		[Ordinal(40)] 
		[RED("item")] 
		public CString Item
		{
			get => GetProperty(ref _item);
			set => SetProperty(ref _item, value);
		}

		[Ordinal(41)] 
		[RED("interaction")] 
		public CHandle<gameinteractionsComponent> Interaction
		{
			get => GetProperty(ref _interaction);
			set => SetProperty(ref _interaction, value);
		}

		[Ordinal(42)] 
		[RED("mesh")] 
		public CHandle<entPhysicalMeshComponent> Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		[Ordinal(43)] 
		[RED("mesh1")] 
		public CHandle<entPhysicalMeshComponent> Mesh1
		{
			get => GetProperty(ref _mesh1);
			set => SetProperty(ref _mesh1, value);
		}

		[Ordinal(44)] 
		[RED("mesh2")] 
		public CHandle<entPhysicalMeshComponent> Mesh2
		{
			get => GetProperty(ref _mesh2);
			set => SetProperty(ref _mesh2, value);
		}

		[Ordinal(45)] 
		[RED("mesh3")] 
		public CHandle<entPhysicalMeshComponent> Mesh3
		{
			get => GetProperty(ref _mesh3);
			set => SetProperty(ref _mesh3, value);
		}

		[Ordinal(46)] 
		[RED("mesh4")] 
		public CHandle<entPhysicalMeshComponent> Mesh4
		{
			get => GetProperty(ref _mesh4);
			set => SetProperty(ref _mesh4, value);
		}
	}
}

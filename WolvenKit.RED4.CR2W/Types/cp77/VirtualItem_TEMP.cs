using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VirtualItem_TEMP : gameObject
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
			get
			{
				if (_item == null)
				{
					_item = (CString) CR2WTypeManager.Create("String", "item", cr2w, this);
				}
				return _item;
			}
			set
			{
				if (_item == value)
				{
					return;
				}
				_item = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("interaction")] 
		public CHandle<gameinteractionsComponent> Interaction
		{
			get
			{
				if (_interaction == null)
				{
					_interaction = (CHandle<gameinteractionsComponent>) CR2WTypeManager.Create("handle:gameinteractionsComponent", "interaction", cr2w, this);
				}
				return _interaction;
			}
			set
			{
				if (_interaction == value)
				{
					return;
				}
				_interaction = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("mesh")] 
		public CHandle<entPhysicalMeshComponent> Mesh
		{
			get
			{
				if (_mesh == null)
				{
					_mesh = (CHandle<entPhysicalMeshComponent>) CR2WTypeManager.Create("handle:entPhysicalMeshComponent", "mesh", cr2w, this);
				}
				return _mesh;
			}
			set
			{
				if (_mesh == value)
				{
					return;
				}
				_mesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("mesh1")] 
		public CHandle<entPhysicalMeshComponent> Mesh1
		{
			get
			{
				if (_mesh1 == null)
				{
					_mesh1 = (CHandle<entPhysicalMeshComponent>) CR2WTypeManager.Create("handle:entPhysicalMeshComponent", "mesh1", cr2w, this);
				}
				return _mesh1;
			}
			set
			{
				if (_mesh1 == value)
				{
					return;
				}
				_mesh1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("mesh2")] 
		public CHandle<entPhysicalMeshComponent> Mesh2
		{
			get
			{
				if (_mesh2 == null)
				{
					_mesh2 = (CHandle<entPhysicalMeshComponent>) CR2WTypeManager.Create("handle:entPhysicalMeshComponent", "mesh2", cr2w, this);
				}
				return _mesh2;
			}
			set
			{
				if (_mesh2 == value)
				{
					return;
				}
				_mesh2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("mesh3")] 
		public CHandle<entPhysicalMeshComponent> Mesh3
		{
			get
			{
				if (_mesh3 == null)
				{
					_mesh3 = (CHandle<entPhysicalMeshComponent>) CR2WTypeManager.Create("handle:entPhysicalMeshComponent", "mesh3", cr2w, this);
				}
				return _mesh3;
			}
			set
			{
				if (_mesh3 == value)
				{
					return;
				}
				_mesh3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("mesh4")] 
		public CHandle<entPhysicalMeshComponent> Mesh4
		{
			get
			{
				if (_mesh4 == null)
				{
					_mesh4 = (CHandle<entPhysicalMeshComponent>) CR2WTypeManager.Create("handle:entPhysicalMeshComponent", "mesh4", cr2w, this);
				}
				return _mesh4;
			}
			set
			{
				if (_mesh4 == value)
				{
					return;
				}
				_mesh4 = value;
				PropertySet(this);
			}
		}

		public VirtualItem_TEMP(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

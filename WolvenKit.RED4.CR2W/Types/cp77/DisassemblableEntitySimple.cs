using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisassemblableEntitySimple : InteractiveDevice
	{
		private CHandle<entMeshComponent> _mesh;
		private CHandle<entIComponent> _collider;

		[Ordinal(93)] 
		[RED("mesh")] 
		public CHandle<entMeshComponent> Mesh
		{
			get
			{
				if (_mesh == null)
				{
					_mesh = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "mesh", cr2w, this);
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

		[Ordinal(94)] 
		[RED("collider")] 
		public CHandle<entIComponent> Collider
		{
			get
			{
				if (_collider == null)
				{
					_collider = (CHandle<entIComponent>) CR2WTypeManager.Create("handle:entIComponent", "collider", cr2w, this);
				}
				return _collider;
			}
			set
			{
				if (_collider == value)
				{
					return;
				}
				_collider = value;
				PropertySet(this);
			}
		}

		public DisassemblableEntitySimple(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

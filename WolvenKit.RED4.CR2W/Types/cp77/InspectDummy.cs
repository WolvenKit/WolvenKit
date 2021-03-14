using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InspectDummy : gameObject
	{
		private CHandle<entPhysicalMeshComponent> _mesh;
		private CHandle<gameinteractionsComponent> _choice;
		private CHandle<InspectableObjectComponent> _inspectComp;

		[Ordinal(40)] 
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

		[Ordinal(41)] 
		[RED("choice")] 
		public CHandle<gameinteractionsComponent> Choice
		{
			get
			{
				if (_choice == null)
				{
					_choice = (CHandle<gameinteractionsComponent>) CR2WTypeManager.Create("handle:gameinteractionsComponent", "choice", cr2w, this);
				}
				return _choice;
			}
			set
			{
				if (_choice == value)
				{
					return;
				}
				_choice = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("inspectComp")] 
		public CHandle<InspectableObjectComponent> InspectComp
		{
			get
			{
				if (_inspectComp == null)
				{
					_inspectComp = (CHandle<InspectableObjectComponent>) CR2WTypeManager.Create("handle:InspectableObjectComponent", "inspectComp", cr2w, this);
				}
				return _inspectComp;
			}
			set
			{
				if (_inspectComp == value)
				{
					return;
				}
				_inspectComp = value;
				PropertySet(this);
			}
		}

		public InspectDummy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

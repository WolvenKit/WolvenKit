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
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		[Ordinal(41)] 
		[RED("choice")] 
		public CHandle<gameinteractionsComponent> Choice
		{
			get => GetProperty(ref _choice);
			set => SetProperty(ref _choice, value);
		}

		[Ordinal(42)] 
		[RED("inspectComp")] 
		public CHandle<InspectableObjectComponent> InspectComp
		{
			get => GetProperty(ref _inspectComp);
			set => SetProperty(ref _inspectComp, value);
		}

		public InspectDummy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

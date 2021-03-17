using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCHotSpotAreaFilterDefinition : gameinteractionsNodeDefinition
	{
		private CName _slotName;
		private Transform _transform;
		private CHandle<gameinteractionsCFunctorDefinition> _functor;
		private CArray<CHandle<gameinteractionsIShapeDefinition>> _shapes;
		private CArray<CHandle<gameinteractionsIShapeDefinition>> _negativeShapes;

		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(1)] 
		[RED("transform")] 
		public Transform Transform
		{
			get => GetProperty(ref _transform);
			set => SetProperty(ref _transform, value);
		}

		[Ordinal(2)] 
		[RED("functor")] 
		public CHandle<gameinteractionsCFunctorDefinition> Functor
		{
			get => GetProperty(ref _functor);
			set => SetProperty(ref _functor, value);
		}

		[Ordinal(3)] 
		[RED("shapes")] 
		public CArray<CHandle<gameinteractionsIShapeDefinition>> Shapes
		{
			get => GetProperty(ref _shapes);
			set => SetProperty(ref _shapes, value);
		}

		[Ordinal(4)] 
		[RED("negativeShapes")] 
		public CArray<CHandle<gameinteractionsIShapeDefinition>> NegativeShapes
		{
			get => GetProperty(ref _negativeShapes);
			set => SetProperty(ref _negativeShapes, value);
		}

		public gameinteractionsCHotSpotAreaFilterDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

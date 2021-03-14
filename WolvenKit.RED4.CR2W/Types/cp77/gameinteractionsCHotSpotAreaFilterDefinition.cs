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
			get
			{
				if (_slotName == null)
				{
					_slotName = (CName) CR2WTypeManager.Create("CName", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("transform")] 
		public Transform Transform
		{
			get
			{
				if (_transform == null)
				{
					_transform = (Transform) CR2WTypeManager.Create("Transform", "transform", cr2w, this);
				}
				return _transform;
			}
			set
			{
				if (_transform == value)
				{
					return;
				}
				_transform = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("functor")] 
		public CHandle<gameinteractionsCFunctorDefinition> Functor
		{
			get
			{
				if (_functor == null)
				{
					_functor = (CHandle<gameinteractionsCFunctorDefinition>) CR2WTypeManager.Create("handle:gameinteractionsCFunctorDefinition", "functor", cr2w, this);
				}
				return _functor;
			}
			set
			{
				if (_functor == value)
				{
					return;
				}
				_functor = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("shapes")] 
		public CArray<CHandle<gameinteractionsIShapeDefinition>> Shapes
		{
			get
			{
				if (_shapes == null)
				{
					_shapes = (CArray<CHandle<gameinteractionsIShapeDefinition>>) CR2WTypeManager.Create("array:handle:gameinteractionsIShapeDefinition", "shapes", cr2w, this);
				}
				return _shapes;
			}
			set
			{
				if (_shapes == value)
				{
					return;
				}
				_shapes = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("negativeShapes")] 
		public CArray<CHandle<gameinteractionsIShapeDefinition>> NegativeShapes
		{
			get
			{
				if (_negativeShapes == null)
				{
					_negativeShapes = (CArray<CHandle<gameinteractionsIShapeDefinition>>) CR2WTypeManager.Create("array:handle:gameinteractionsIShapeDefinition", "negativeShapes", cr2w, this);
				}
				return _negativeShapes;
			}
			set
			{
				if (_negativeShapes == value)
				{
					return;
				}
				_negativeShapes = value;
				PropertySet(this);
			}
		}

		public gameinteractionsCHotSpotAreaFilterDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

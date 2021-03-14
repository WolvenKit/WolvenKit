using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsInteractionDefinitionOverrider : CVariable
	{
		private CName _tag;
		private CArray<CHandle<gameinteractionsIShapeDefinition>> _shapes;
		private CArray<CHandle<gameinteractionsIShapeDefinition>> _negativeShapes;
		private CFloat _priorityMultiplier;

		[Ordinal(0)] 
		[RED("tag")] 
		public CName Tag
		{
			get
			{
				if (_tag == null)
				{
					_tag = (CName) CR2WTypeManager.Create("CName", "tag", cr2w, this);
				}
				return _tag;
			}
			set
			{
				if (_tag == value)
				{
					return;
				}
				_tag = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("priorityMultiplier")] 
		public CFloat PriorityMultiplier
		{
			get
			{
				if (_priorityMultiplier == null)
				{
					_priorityMultiplier = (CFloat) CR2WTypeManager.Create("Float", "priorityMultiplier", cr2w, this);
				}
				return _priorityMultiplier;
			}
			set
			{
				if (_priorityMultiplier == value)
				{
					return;
				}
				_priorityMultiplier = value;
				PropertySet(this);
			}
		}

		public gameinteractionsInteractionDefinitionOverrider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

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
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		[Ordinal(1)] 
		[RED("shapes")] 
		public CArray<CHandle<gameinteractionsIShapeDefinition>> Shapes
		{
			get => GetProperty(ref _shapes);
			set => SetProperty(ref _shapes, value);
		}

		[Ordinal(2)] 
		[RED("negativeShapes")] 
		public CArray<CHandle<gameinteractionsIShapeDefinition>> NegativeShapes
		{
			get => GetProperty(ref _negativeShapes);
			set => SetProperty(ref _negativeShapes, value);
		}

		[Ordinal(3)] 
		[RED("priorityMultiplier")] 
		public CFloat PriorityMultiplier
		{
			get => GetProperty(ref _priorityMultiplier);
			set => SetProperty(ref _priorityMultiplier, value);
		}

		public gameinteractionsInteractionDefinitionOverrider(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

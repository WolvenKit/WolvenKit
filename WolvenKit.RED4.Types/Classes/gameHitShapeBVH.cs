using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameHitShapeBVH : RedBaseClass
	{
		private CName _nodeName;
		private CArray<gameHitShapeBVH> _childrenNodes;
		private CArray<CName> _childrenShapeNames;

		[Ordinal(0)] 
		[RED("nodeName")] 
		public CName NodeName
		{
			get => GetProperty(ref _nodeName);
			set => SetProperty(ref _nodeName, value);
		}

		[Ordinal(1)] 
		[RED("childrenNodes")] 
		public CArray<gameHitShapeBVH> ChildrenNodes
		{
			get => GetProperty(ref _childrenNodes);
			set => SetProperty(ref _childrenNodes, value);
		}

		[Ordinal(2)] 
		[RED("childrenShapeNames")] 
		public CArray<CName> ChildrenShapeNames
		{
			get => GetProperty(ref _childrenShapeNames);
			set => SetProperty(ref _childrenShapeNames, value);
		}
	}
}

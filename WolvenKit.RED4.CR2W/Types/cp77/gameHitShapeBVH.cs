using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitShapeBVH : CVariable
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

		public gameHitShapeBVH(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

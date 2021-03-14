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
			get
			{
				if (_nodeName == null)
				{
					_nodeName = (CName) CR2WTypeManager.Create("CName", "nodeName", cr2w, this);
				}
				return _nodeName;
			}
			set
			{
				if (_nodeName == value)
				{
					return;
				}
				_nodeName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("childrenNodes")] 
		public CArray<gameHitShapeBVH> ChildrenNodes
		{
			get
			{
				if (_childrenNodes == null)
				{
					_childrenNodes = (CArray<gameHitShapeBVH>) CR2WTypeManager.Create("array:gameHitShapeBVH", "childrenNodes", cr2w, this);
				}
				return _childrenNodes;
			}
			set
			{
				if (_childrenNodes == value)
				{
					return;
				}
				_childrenNodes = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("childrenShapeNames")] 
		public CArray<CName> ChildrenShapeNames
		{
			get
			{
				if (_childrenShapeNames == null)
				{
					_childrenShapeNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "childrenShapeNames", cr2w, this);
				}
				return _childrenShapeNames;
			}
			set
			{
				if (_childrenShapeNames == value)
				{
					return;
				}
				_childrenShapeNames = value;
				PropertySet(this);
			}
		}

		public gameHitShapeBVH(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

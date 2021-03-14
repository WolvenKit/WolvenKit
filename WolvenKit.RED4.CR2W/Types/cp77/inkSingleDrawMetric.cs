using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkSingleDrawMetric : CVariable
	{
		private CBool _exeedsLimit;
		private Vector2 _hierarchySize;
		private CArray<CUInt32> _usedTextures;

		[Ordinal(0)] 
		[RED("exeedsLimit")] 
		public CBool ExeedsLimit
		{
			get
			{
				if (_exeedsLimit == null)
				{
					_exeedsLimit = (CBool) CR2WTypeManager.Create("Bool", "exeedsLimit", cr2w, this);
				}
				return _exeedsLimit;
			}
			set
			{
				if (_exeedsLimit == value)
				{
					return;
				}
				_exeedsLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hierarchySize")] 
		public Vector2 HierarchySize
		{
			get
			{
				if (_hierarchySize == null)
				{
					_hierarchySize = (Vector2) CR2WTypeManager.Create("Vector2", "hierarchySize", cr2w, this);
				}
				return _hierarchySize;
			}
			set
			{
				if (_hierarchySize == value)
				{
					return;
				}
				_hierarchySize = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("usedTextures")] 
		public CArray<CUInt32> UsedTextures
		{
			get
			{
				if (_usedTextures == null)
				{
					_usedTextures = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "usedTextures", cr2w, this);
				}
				return _usedTextures;
			}
			set
			{
				if (_usedTextures == value)
				{
					return;
				}
				_usedTextures = value;
				PropertySet(this);
			}
		}

		public inkSingleDrawMetric(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

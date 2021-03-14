using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldBlockoutArea : ISerializable
	{
		private CString _name;
		private CColor _color;
		private CUInt32 _parent;
		private CArray<CUInt32> _children;
		private CArray<CHandle<worldBlockoutAreaOutline>> _outlines;
		private CBool _isFree;
		private CBool _increaseTerrainStreamingDistance;

		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CString) CR2WTypeManager.Create("String", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("color")] 
		public CColor Color
		{
			get
			{
				if (_color == null)
				{
					_color = (CColor) CR2WTypeManager.Create("Color", "color", cr2w, this);
				}
				return _color;
			}
			set
			{
				if (_color == value)
				{
					return;
				}
				_color = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("parent")] 
		public CUInt32 Parent
		{
			get
			{
				if (_parent == null)
				{
					_parent = (CUInt32) CR2WTypeManager.Create("Uint32", "parent", cr2w, this);
				}
				return _parent;
			}
			set
			{
				if (_parent == value)
				{
					return;
				}
				_parent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("children")] 
		public CArray<CUInt32> Children
		{
			get
			{
				if (_children == null)
				{
					_children = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "children", cr2w, this);
				}
				return _children;
			}
			set
			{
				if (_children == value)
				{
					return;
				}
				_children = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("outlines")] 
		public CArray<CHandle<worldBlockoutAreaOutline>> Outlines
		{
			get
			{
				if (_outlines == null)
				{
					_outlines = (CArray<CHandle<worldBlockoutAreaOutline>>) CR2WTypeManager.Create("array:handle:worldBlockoutAreaOutline", "outlines", cr2w, this);
				}
				return _outlines;
			}
			set
			{
				if (_outlines == value)
				{
					return;
				}
				_outlines = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isFree")] 
		public CBool IsFree
		{
			get
			{
				if (_isFree == null)
				{
					_isFree = (CBool) CR2WTypeManager.Create("Bool", "isFree", cr2w, this);
				}
				return _isFree;
			}
			set
			{
				if (_isFree == value)
				{
					return;
				}
				_isFree = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("increaseTerrainStreamingDistance")] 
		public CBool IncreaseTerrainStreamingDistance
		{
			get
			{
				if (_increaseTerrainStreamingDistance == null)
				{
					_increaseTerrainStreamingDistance = (CBool) CR2WTypeManager.Create("Bool", "increaseTerrainStreamingDistance", cr2w, this);
				}
				return _increaseTerrainStreamingDistance;
			}
			set
			{
				if (_increaseTerrainStreamingDistance == value)
				{
					return;
				}
				_increaseTerrainStreamingDistance = value;
				PropertySet(this);
			}
		}

		public worldBlockoutArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldBlockoutPoint : ISerializable
	{
		private Vector2 _position;
		private CArray<CUInt32> _edges;
		private CInt32 _constraint;
		private CBool _isFree;

		[Ordinal(0)] 
		[RED("position")] 
		public Vector2 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector2) CR2WTypeManager.Create("Vector2", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("edges")] 
		public CArray<CUInt32> Edges
		{
			get
			{
				if (_edges == null)
				{
					_edges = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "edges", cr2w, this);
				}
				return _edges;
			}
			set
			{
				if (_edges == value)
				{
					return;
				}
				_edges = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("constraint")] 
		public CInt32 Constraint
		{
			get
			{
				if (_constraint == null)
				{
					_constraint = (CInt32) CR2WTypeManager.Create("Int32", "constraint", cr2w, this);
				}
				return _constraint;
			}
			set
			{
				if (_constraint == value)
				{
					return;
				}
				_constraint = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		public worldBlockoutPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

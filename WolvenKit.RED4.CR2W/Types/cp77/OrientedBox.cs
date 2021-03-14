using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OrientedBox : CVariable
	{
		private Vector4 _position;
		private Vector4 _edge_1;
		private Vector4 _edge_2;

		[Ordinal(0)] 
		[RED("position")] 
		public Vector4 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector4) CR2WTypeManager.Create("Vector4", "position", cr2w, this);
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
		[RED("edge 1")] 
		public Vector4 Edge_1
		{
			get
			{
				if (_edge_1 == null)
				{
					_edge_1 = (Vector4) CR2WTypeManager.Create("Vector4", "edge 1", cr2w, this);
				}
				return _edge_1;
			}
			set
			{
				if (_edge_1 == value)
				{
					return;
				}
				_edge_1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("edge 2")] 
		public Vector4 Edge_2
		{
			get
			{
				if (_edge_2 == null)
				{
					_edge_2 = (Vector4) CR2WTypeManager.Create("Vector4", "edge 2", cr2w, this);
				}
				return _edge_2;
			}
			set
			{
				if (_edge_2 == value)
				{
					return;
				}
				_edge_2 = value;
				PropertySet(this);
			}
		}

		public OrientedBox(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCookedDeviceData : CVariable
	{
		private CName _className;
		private CArray<CUInt64> _parents;
		private CArray<CUInt64> _children;
		private Vector3 _nodePosition;

		[Ordinal(0)] 
		[RED("className")] 
		public CName ClassName
		{
			get
			{
				if (_className == null)
				{
					_className = (CName) CR2WTypeManager.Create("CName", "className", cr2w, this);
				}
				return _className;
			}
			set
			{
				if (_className == value)
				{
					return;
				}
				_className = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("parents")] 
		public CArray<CUInt64> Parents
		{
			get
			{
				if (_parents == null)
				{
					_parents = (CArray<CUInt64>) CR2WTypeManager.Create("array:Uint64", "parents", cr2w, this);
				}
				return _parents;
			}
			set
			{
				if (_parents == value)
				{
					return;
				}
				_parents = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("children")] 
		public CArray<CUInt64> Children
		{
			get
			{
				if (_children == null)
				{
					_children = (CArray<CUInt64>) CR2WTypeManager.Create("array:Uint64", "children", cr2w, this);
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

		[Ordinal(3)] 
		[RED("nodePosition")] 
		public Vector3 NodePosition
		{
			get
			{
				if (_nodePosition == null)
				{
					_nodePosition = (Vector3) CR2WTypeManager.Create("Vector3", "nodePosition", cr2w, this);
				}
				return _nodePosition;
			}
			set
			{
				if (_nodePosition == value)
				{
					return;
				}
				_nodePosition = value;
				PropertySet(this);
			}
		}

		public gameCookedDeviceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

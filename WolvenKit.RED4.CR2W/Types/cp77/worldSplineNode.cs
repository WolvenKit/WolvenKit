using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSplineNode : worldSocketNode
	{
		private CHandle<Spline> _splineData;
		private NodeRef _destSnapedNode;
		private CName _destSnapedSocketName;
		private NodeRef _entrySnapedNode;
		private CName _entrySnapedSocketName;

		[Ordinal(4)] 
		[RED("splineData")] 
		public CHandle<Spline> SplineData
		{
			get
			{
				if (_splineData == null)
				{
					_splineData = (CHandle<Spline>) CR2WTypeManager.Create("handle:Spline", "splineData", cr2w, this);
				}
				return _splineData;
			}
			set
			{
				if (_splineData == value)
				{
					return;
				}
				_splineData = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("destSnapedNode")] 
		public NodeRef DestSnapedNode
		{
			get
			{
				if (_destSnapedNode == null)
				{
					_destSnapedNode = (NodeRef) CR2WTypeManager.Create("NodeRef", "destSnapedNode", cr2w, this);
				}
				return _destSnapedNode;
			}
			set
			{
				if (_destSnapedNode == value)
				{
					return;
				}
				_destSnapedNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("destSnapedSocketName")] 
		public CName DestSnapedSocketName
		{
			get
			{
				if (_destSnapedSocketName == null)
				{
					_destSnapedSocketName = (CName) CR2WTypeManager.Create("CName", "destSnapedSocketName", cr2w, this);
				}
				return _destSnapedSocketName;
			}
			set
			{
				if (_destSnapedSocketName == value)
				{
					return;
				}
				_destSnapedSocketName = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("entrySnapedNode")] 
		public NodeRef EntrySnapedNode
		{
			get
			{
				if (_entrySnapedNode == null)
				{
					_entrySnapedNode = (NodeRef) CR2WTypeManager.Create("NodeRef", "entrySnapedNode", cr2w, this);
				}
				return _entrySnapedNode;
			}
			set
			{
				if (_entrySnapedNode == value)
				{
					return;
				}
				_entrySnapedNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("entrySnapedSocketName")] 
		public CName EntrySnapedSocketName
		{
			get
			{
				if (_entrySnapedSocketName == null)
				{
					_entrySnapedSocketName = (CName) CR2WTypeManager.Create("CName", "entrySnapedSocketName", cr2w, this);
				}
				return _entrySnapedSocketName;
			}
			set
			{
				if (_entrySnapedSocketName == value)
				{
					return;
				}
				_entrySnapedSocketName = value;
				PropertySet(this);
			}
		}

		public worldSplineNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

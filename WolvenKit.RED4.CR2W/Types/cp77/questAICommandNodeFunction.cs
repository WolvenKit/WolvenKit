using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAICommandNodeFunction : CVariable
	{
		private CUInt32 _order;
		private CName _nodeType;
		private CName _commandCategory;
		private CString _friendlyName;
		private CName _paramsType;
		private CColor _nodeColor;

		[Ordinal(0)] 
		[RED("order")] 
		public CUInt32 Order
		{
			get
			{
				if (_order == null)
				{
					_order = (CUInt32) CR2WTypeManager.Create("Uint32", "order", cr2w, this);
				}
				return _order;
			}
			set
			{
				if (_order == value)
				{
					return;
				}
				_order = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("nodeType")] 
		public CName NodeType
		{
			get
			{
				if (_nodeType == null)
				{
					_nodeType = (CName) CR2WTypeManager.Create("CName", "nodeType", cr2w, this);
				}
				return _nodeType;
			}
			set
			{
				if (_nodeType == value)
				{
					return;
				}
				_nodeType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("commandCategory")] 
		public CName CommandCategory
		{
			get
			{
				if (_commandCategory == null)
				{
					_commandCategory = (CName) CR2WTypeManager.Create("CName", "commandCategory", cr2w, this);
				}
				return _commandCategory;
			}
			set
			{
				if (_commandCategory == value)
				{
					return;
				}
				_commandCategory = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("friendlyName")] 
		public CString FriendlyName
		{
			get
			{
				if (_friendlyName == null)
				{
					_friendlyName = (CString) CR2WTypeManager.Create("String", "friendlyName", cr2w, this);
				}
				return _friendlyName;
			}
			set
			{
				if (_friendlyName == value)
				{
					return;
				}
				_friendlyName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("paramsType")] 
		public CName ParamsType
		{
			get
			{
				if (_paramsType == null)
				{
					_paramsType = (CName) CR2WTypeManager.Create("CName", "paramsType", cr2w, this);
				}
				return _paramsType;
			}
			set
			{
				if (_paramsType == value)
				{
					return;
				}
				_paramsType = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("nodeColor")] 
		public CColor NodeColor
		{
			get
			{
				if (_nodeColor == null)
				{
					_nodeColor = (CColor) CR2WTypeManager.Create("Color", "nodeColor", cr2w, this);
				}
				return _nodeColor;
			}
			set
			{
				if (_nodeColor == value)
				{
					return;
				}
				_nodeColor = value;
				PropertySet(this);
			}
		}

		public questAICommandNodeFunction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

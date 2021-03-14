using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetRunnerChargesGameController : gameuiWidgetGameController
	{
		private inkTextWidgetReference _header;
		private inkCompoundWidgetReference _list;
		private inkWidgetReference _bar;
		private inkTextWidgetReference _value;
		private CHandle<gameIBlackboard> _blackboard;
		private CHandle<UI_PlayerBioMonitorDef> _bbDefinition;
		private CUInt32 _netrunnerCapacityId;
		private CUInt32 _netrunnerCurrentId;
		private CInt32 _currentCharges;
		private CInt32 _maxCharges;
		private CArray<CHandle<NetRunnerListItem>> _chargesList;
		private wCHandle<inkWidget> _root;

		[Ordinal(2)] 
		[RED("header")] 
		public inkTextWidgetReference Header
		{
			get
			{
				if (_header == null)
				{
					_header = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "header", cr2w, this);
				}
				return _header;
			}
			set
			{
				if (_header == value)
				{
					return;
				}
				_header = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("list")] 
		public inkCompoundWidgetReference List
		{
			get
			{
				if (_list == null)
				{
					_list = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "list", cr2w, this);
				}
				return _list;
			}
			set
			{
				if (_list == value)
				{
					return;
				}
				_list = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("bar")] 
		public inkWidgetReference Bar
		{
			get
			{
				if (_bar == null)
				{
					_bar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "bar", cr2w, this);
				}
				return _bar;
			}
			set
			{
				if (_bar == value)
				{
					return;
				}
				_bar = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("value")] 
		public inkTextWidgetReference Value
		{
			get
			{
				if (_value == null)
				{
					_value = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("blackboard")] 
		public CHandle<gameIBlackboard> Blackboard
		{
			get
			{
				if (_blackboard == null)
				{
					_blackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "blackboard", cr2w, this);
				}
				return _blackboard;
			}
			set
			{
				if (_blackboard == value)
				{
					return;
				}
				_blackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("bbDefinition")] 
		public CHandle<UI_PlayerBioMonitorDef> BbDefinition
		{
			get
			{
				if (_bbDefinition == null)
				{
					_bbDefinition = (CHandle<UI_PlayerBioMonitorDef>) CR2WTypeManager.Create("handle:UI_PlayerBioMonitorDef", "bbDefinition", cr2w, this);
				}
				return _bbDefinition;
			}
			set
			{
				if (_bbDefinition == value)
				{
					return;
				}
				_bbDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("netrunnerCapacityId")] 
		public CUInt32 NetrunnerCapacityId
		{
			get
			{
				if (_netrunnerCapacityId == null)
				{
					_netrunnerCapacityId = (CUInt32) CR2WTypeManager.Create("Uint32", "netrunnerCapacityId", cr2w, this);
				}
				return _netrunnerCapacityId;
			}
			set
			{
				if (_netrunnerCapacityId == value)
				{
					return;
				}
				_netrunnerCapacityId = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("netrunnerCurrentId")] 
		public CUInt32 NetrunnerCurrentId
		{
			get
			{
				if (_netrunnerCurrentId == null)
				{
					_netrunnerCurrentId = (CUInt32) CR2WTypeManager.Create("Uint32", "netrunnerCurrentId", cr2w, this);
				}
				return _netrunnerCurrentId;
			}
			set
			{
				if (_netrunnerCurrentId == value)
				{
					return;
				}
				_netrunnerCurrentId = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("currentCharges")] 
		public CInt32 CurrentCharges
		{
			get
			{
				if (_currentCharges == null)
				{
					_currentCharges = (CInt32) CR2WTypeManager.Create("Int32", "currentCharges", cr2w, this);
				}
				return _currentCharges;
			}
			set
			{
				if (_currentCharges == value)
				{
					return;
				}
				_currentCharges = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("maxCharges")] 
		public CInt32 MaxCharges
		{
			get
			{
				if (_maxCharges == null)
				{
					_maxCharges = (CInt32) CR2WTypeManager.Create("Int32", "maxCharges", cr2w, this);
				}
				return _maxCharges;
			}
			set
			{
				if (_maxCharges == value)
				{
					return;
				}
				_maxCharges = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("chargesList")] 
		public CArray<CHandle<NetRunnerListItem>> ChargesList
		{
			get
			{
				if (_chargesList == null)
				{
					_chargesList = (CArray<CHandle<NetRunnerListItem>>) CR2WTypeManager.Create("array:handle:NetRunnerListItem", "chargesList", cr2w, this);
				}
				return _chargesList;
			}
			set
			{
				if (_chargesList == value)
				{
					return;
				}
				_chargesList = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		public NetRunnerChargesGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VirutalNestedListData : IScriptable
	{
		private CBool _collapsable;
		private CBool _isHeader;
		private CInt32 _level;
		private CUInt32 _widgetType;
		private CHandle<IScriptable> _data;

		[Ordinal(0)] 
		[RED("collapsable")] 
		public CBool Collapsable
		{
			get
			{
				if (_collapsable == null)
				{
					_collapsable = (CBool) CR2WTypeManager.Create("Bool", "collapsable", cr2w, this);
				}
				return _collapsable;
			}
			set
			{
				if (_collapsable == value)
				{
					return;
				}
				_collapsable = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isHeader")] 
		public CBool IsHeader
		{
			get
			{
				if (_isHeader == null)
				{
					_isHeader = (CBool) CR2WTypeManager.Create("Bool", "isHeader", cr2w, this);
				}
				return _isHeader;
			}
			set
			{
				if (_isHeader == value)
				{
					return;
				}
				_isHeader = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("level")] 
		public CInt32 Level
		{
			get
			{
				if (_level == null)
				{
					_level = (CInt32) CR2WTypeManager.Create("Int32", "level", cr2w, this);
				}
				return _level;
			}
			set
			{
				if (_level == value)
				{
					return;
				}
				_level = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("widgetType")] 
		public CUInt32 WidgetType
		{
			get
			{
				if (_widgetType == null)
				{
					_widgetType = (CUInt32) CR2WTypeManager.Create("Uint32", "widgetType", cr2w, this);
				}
				return _widgetType;
			}
			set
			{
				if (_widgetType == value)
				{
					return;
				}
				_widgetType = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("data")] 
		public CHandle<IScriptable> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<IScriptable>) CR2WTypeManager.Create("handle:IScriptable", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public VirutalNestedListData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

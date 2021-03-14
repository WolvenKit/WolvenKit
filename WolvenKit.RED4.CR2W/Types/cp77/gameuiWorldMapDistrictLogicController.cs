using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiWorldMapDistrictLogicController : inkWidgetLogicController
	{
		private wCHandle<gamedataDistrict_Record> _record;
		private CEnum<gamedataDistrict> _type;
		private CBool _selected;
		private inkLinePatternWidgetReference _outlineWidget;
		private inkImageWidgetReference _iconWidget;
		private CHandle<inkanimProxy> _selectAnim;

		[Ordinal(1)] 
		[RED("record")] 
		public wCHandle<gamedataDistrict_Record> Record
		{
			get
			{
				if (_record == null)
				{
					_record = (wCHandle<gamedataDistrict_Record>) CR2WTypeManager.Create("whandle:gamedataDistrict_Record", "record", cr2w, this);
				}
				return _record;
			}
			set
			{
				if (_record == value)
				{
					return;
				}
				_record = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<gamedataDistrict> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gamedataDistrict>) CR2WTypeManager.Create("gamedataDistrict", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("selected")] 
		public CBool Selected
		{
			get
			{
				if (_selected == null)
				{
					_selected = (CBool) CR2WTypeManager.Create("Bool", "selected", cr2w, this);
				}
				return _selected;
			}
			set
			{
				if (_selected == value)
				{
					return;
				}
				_selected = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("outlineWidget")] 
		public inkLinePatternWidgetReference OutlineWidget
		{
			get
			{
				if (_outlineWidget == null)
				{
					_outlineWidget = (inkLinePatternWidgetReference) CR2WTypeManager.Create("inkLinePatternWidgetReference", "outlineWidget", cr2w, this);
				}
				return _outlineWidget;
			}
			set
			{
				if (_outlineWidget == value)
				{
					return;
				}
				_outlineWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("iconWidget")] 
		public inkImageWidgetReference IconWidget
		{
			get
			{
				if (_iconWidget == null)
				{
					_iconWidget = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "iconWidget", cr2w, this);
				}
				return _iconWidget;
			}
			set
			{
				if (_iconWidget == value)
				{
					return;
				}
				_iconWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("selectAnim")] 
		public CHandle<inkanimProxy> SelectAnim
		{
			get
			{
				if (_selectAnim == null)
				{
					_selectAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "selectAnim", cr2w, this);
				}
				return _selectAnim;
			}
			set
			{
				if (_selectAnim == value)
				{
					return;
				}
				_selectAnim = value;
				PropertySet(this);
			}
		}

		public gameuiWorldMapDistrictLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

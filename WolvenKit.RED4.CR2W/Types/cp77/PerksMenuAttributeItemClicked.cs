using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerksMenuAttributeItemClicked : redEvent
	{
		private wCHandle<inkWidget> _widget;
		private CEnum<PerkMenuAttribute> _attributeType;
		private CHandle<AttributeData> _attributeData;

		[Ordinal(0)] 
		[RED("widget")] 
		public wCHandle<inkWidget> Widget
		{
			get
			{
				if (_widget == null)
				{
					_widget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "widget", cr2w, this);
				}
				return _widget;
			}
			set
			{
				if (_widget == value)
				{
					return;
				}
				_widget = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("attributeType")] 
		public CEnum<PerkMenuAttribute> AttributeType
		{
			get
			{
				if (_attributeType == null)
				{
					_attributeType = (CEnum<PerkMenuAttribute>) CR2WTypeManager.Create("PerkMenuAttribute", "attributeType", cr2w, this);
				}
				return _attributeType;
			}
			set
			{
				if (_attributeType == value)
				{
					return;
				}
				_attributeType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("attributeData")] 
		public CHandle<AttributeData> AttributeData
		{
			get
			{
				if (_attributeData == null)
				{
					_attributeData = (CHandle<AttributeData>) CR2WTypeManager.Create("handle:AttributeData", "attributeData", cr2w, this);
				}
				return _attributeData;
			}
			set
			{
				if (_attributeData == value)
				{
					return;
				}
				_attributeData = value;
				PropertySet(this);
			}
		}

		public PerksMenuAttributeItemClicked(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

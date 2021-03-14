using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareAttributes_Logic : inkWidgetLogicController
	{
		private inkTextWidgetReference _textValue;
		private inkWidgetReference _buttonRef;
		private inkWidgetReference _tooltipRef;
		private inkWidgetReference _connectorRef;

		[Ordinal(1)] 
		[RED("textValue")] 
		public inkTextWidgetReference TextValue
		{
			get
			{
				if (_textValue == null)
				{
					_textValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "textValue", cr2w, this);
				}
				return _textValue;
			}
			set
			{
				if (_textValue == value)
				{
					return;
				}
				_textValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("buttonRef")] 
		public inkWidgetReference ButtonRef
		{
			get
			{
				if (_buttonRef == null)
				{
					_buttonRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonRef", cr2w, this);
				}
				return _buttonRef;
			}
			set
			{
				if (_buttonRef == value)
				{
					return;
				}
				_buttonRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("tooltipRef")] 
		public inkWidgetReference TooltipRef
		{
			get
			{
				if (_tooltipRef == null)
				{
					_tooltipRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "tooltipRef", cr2w, this);
				}
				return _tooltipRef;
			}
			set
			{
				if (_tooltipRef == value)
				{
					return;
				}
				_tooltipRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("connectorRef")] 
		public inkWidgetReference ConnectorRef
		{
			get
			{
				if (_connectorRef == null)
				{
					_connectorRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "connectorRef", cr2w, this);
				}
				return _connectorRef;
			}
			set
			{
				if (_connectorRef == value)
				{
					return;
				}
				_connectorRef = value;
				PropertySet(this);
			}
		}

		public CyberwareAttributes_Logic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

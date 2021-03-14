using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MessageDescTooltip : MessageTooltip
	{
		private inkWidgetReference _titleWrapper;
		private inkWidgetReference _descriptionWrapper;
		private inkWidgetReference _descriptionLine;

		[Ordinal(5)] 
		[RED("titleWrapper")] 
		public inkWidgetReference TitleWrapper
		{
			get
			{
				if (_titleWrapper == null)
				{
					_titleWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "titleWrapper", cr2w, this);
				}
				return _titleWrapper;
			}
			set
			{
				if (_titleWrapper == value)
				{
					return;
				}
				_titleWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("descriptionWrapper")] 
		public inkWidgetReference DescriptionWrapper
		{
			get
			{
				if (_descriptionWrapper == null)
				{
					_descriptionWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "descriptionWrapper", cr2w, this);
				}
				return _descriptionWrapper;
			}
			set
			{
				if (_descriptionWrapper == value)
				{
					return;
				}
				_descriptionWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("descriptionLine")] 
		public inkWidgetReference DescriptionLine
		{
			get
			{
				if (_descriptionLine == null)
				{
					_descriptionLine = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "descriptionLine", cr2w, this);
				}
				return _descriptionLine;
			}
			set
			{
				if (_descriptionLine == value)
				{
					return;
				}
				_descriptionLine = value;
				PropertySet(this);
			}
		}

		public MessageDescTooltip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

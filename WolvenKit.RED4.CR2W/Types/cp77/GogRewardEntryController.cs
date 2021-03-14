using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GogRewardEntryController : inkWidgetLogicController
	{
		private inkWidgetReference _nameWidget;
		private inkWidgetReference _descriptionWidget;
		private inkImageWidgetReference _iconImage;

		[Ordinal(1)] 
		[RED("nameWidget")] 
		public inkWidgetReference NameWidget
		{
			get
			{
				if (_nameWidget == null)
				{
					_nameWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "nameWidget", cr2w, this);
				}
				return _nameWidget;
			}
			set
			{
				if (_nameWidget == value)
				{
					return;
				}
				_nameWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("descriptionWidget")] 
		public inkWidgetReference DescriptionWidget
		{
			get
			{
				if (_descriptionWidget == null)
				{
					_descriptionWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "descriptionWidget", cr2w, this);
				}
				return _descriptionWidget;
			}
			set
			{
				if (_descriptionWidget == value)
				{
					return;
				}
				_descriptionWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("iconImage")] 
		public inkImageWidgetReference IconImage
		{
			get
			{
				if (_iconImage == null)
				{
					_iconImage = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "iconImage", cr2w, this);
				}
				return _iconImage;
			}
			set
			{
				if (_iconImage == value)
				{
					return;
				}
				_iconImage = value;
				PropertySet(this);
			}
		}

		public GogRewardEntryController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

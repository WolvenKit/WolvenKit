using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SocialPanelContactsListItem : inkToggleController
	{
		private inkTextWidgetReference _label;
		private SocialPanelContactInfo _contactInfo;

		[Ordinal(13)] 
		[RED("Label")] 
		public inkTextWidgetReference Label
		{
			get
			{
				if (_label == null)
				{
					_label = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "Label", cr2w, this);
				}
				return _label;
			}
			set
			{
				if (_label == value)
				{
					return;
				}
				_label = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("ContactInfo")] 
		public SocialPanelContactInfo ContactInfo
		{
			get
			{
				if (_contactInfo == null)
				{
					_contactInfo = (SocialPanelContactInfo) CR2WTypeManager.Create("SocialPanelContactInfo", "ContactInfo", cr2w, this);
				}
				return _contactInfo;
			}
			set
			{
				if (_contactInfo == value)
				{
					return;
				}
				_contactInfo = value;
				PropertySet(this);
			}
		}

		public SocialPanelContactsListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

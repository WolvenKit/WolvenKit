using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SocialPanelContactsDetails : inkWidgetLogicController
	{
		private inkImageWidgetReference _contactAvatarRef;
		private inkTextWidgetReference _contactNameRef;
		private inkTextWidgetReference _contactDescriptionRef;

		[Ordinal(1)] 
		[RED("ContactAvatarRef")] 
		public inkImageWidgetReference ContactAvatarRef
		{
			get
			{
				if (_contactAvatarRef == null)
				{
					_contactAvatarRef = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "ContactAvatarRef", cr2w, this);
				}
				return _contactAvatarRef;
			}
			set
			{
				if (_contactAvatarRef == value)
				{
					return;
				}
				_contactAvatarRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ContactNameRef")] 
		public inkTextWidgetReference ContactNameRef
		{
			get
			{
				if (_contactNameRef == null)
				{
					_contactNameRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "ContactNameRef", cr2w, this);
				}
				return _contactNameRef;
			}
			set
			{
				if (_contactNameRef == value)
				{
					return;
				}
				_contactNameRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ContactDescriptionRef")] 
		public inkTextWidgetReference ContactDescriptionRef
		{
			get
			{
				if (_contactDescriptionRef == null)
				{
					_contactDescriptionRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "ContactDescriptionRef", cr2w, this);
				}
				return _contactDescriptionRef;
			}
			set
			{
				if (_contactDescriptionRef == value)
				{
					return;
				}
				_contactDescriptionRef = value;
				PropertySet(this);
			}
		}

		public SocialPanelContactsDetails(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

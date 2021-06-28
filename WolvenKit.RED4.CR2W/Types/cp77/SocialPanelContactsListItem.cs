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
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(14)] 
		[RED("ContactInfo")] 
		public SocialPanelContactInfo ContactInfo
		{
			get => GetProperty(ref _contactInfo);
			set => SetProperty(ref _contactInfo, value);
		}

		public SocialPanelContactsListItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

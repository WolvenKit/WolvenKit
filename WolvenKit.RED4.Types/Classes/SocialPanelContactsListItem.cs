using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SocialPanelContactsListItem : inkToggleController
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
	}
}

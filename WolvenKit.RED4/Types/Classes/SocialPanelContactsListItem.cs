using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SocialPanelContactsListItem : inkToggleController
	{
		[Ordinal(13)] 
		[RED("Label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("ContactInfo")] 
		public SocialPanelContactInfo ContactInfo
		{
			get => GetPropertyValue<SocialPanelContactInfo>();
			set => SetPropertyValue<SocialPanelContactInfo>(value);
		}

		public SocialPanelContactsListItem()
		{
			Label = new inkTextWidgetReference();
			ContactInfo = new SocialPanelContactInfo();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

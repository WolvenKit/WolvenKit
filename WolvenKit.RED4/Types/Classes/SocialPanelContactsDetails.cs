using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SocialPanelContactsDetails : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("ContactAvatarRef")] 
		public inkImageWidgetReference ContactAvatarRef
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("ContactNameRef")] 
		public inkTextWidgetReference ContactNameRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("ContactDescriptionRef")] 
		public inkTextWidgetReference ContactDescriptionRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public SocialPanelContactsDetails()
		{
			ContactAvatarRef = new();
			ContactNameRef = new();
			ContactDescriptionRef = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

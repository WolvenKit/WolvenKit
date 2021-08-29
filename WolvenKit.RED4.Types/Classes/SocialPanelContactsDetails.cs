using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SocialPanelContactsDetails : inkWidgetLogicController
	{
		private inkImageWidgetReference _contactAvatarRef;
		private inkTextWidgetReference _contactNameRef;
		private inkTextWidgetReference _contactDescriptionRef;

		[Ordinal(1)] 
		[RED("ContactAvatarRef")] 
		public inkImageWidgetReference ContactAvatarRef
		{
			get => GetProperty(ref _contactAvatarRef);
			set => SetProperty(ref _contactAvatarRef, value);
		}

		[Ordinal(2)] 
		[RED("ContactNameRef")] 
		public inkTextWidgetReference ContactNameRef
		{
			get => GetProperty(ref _contactNameRef);
			set => SetProperty(ref _contactNameRef, value);
		}

		[Ordinal(3)] 
		[RED("ContactDescriptionRef")] 
		public inkTextWidgetReference ContactDescriptionRef
		{
			get => GetProperty(ref _contactDescriptionRef);
			set => SetProperty(ref _contactDescriptionRef, value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewLocationNotification : JournalNotification
	{
		[Ordinal(16)] 
		[RED("districtName")] 
		public inkTextWidgetReference DistrictName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("districtIcon")] 
		public inkImageWidgetReference DistrictIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("districtFluffIcon")] 
		public inkImageWidgetReference DistrictFluffIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public NewLocationNotification()
		{
			DistrictName = new();
			DistrictIcon = new();
			DistrictFluffIcon = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NewLocationNotification : JournalNotification
	{
		private inkTextWidgetReference _districtName;
		private inkImageWidgetReference _districtIcon;
		private inkImageWidgetReference _districtFluffIcon;

		[Ordinal(16)] 
		[RED("districtName")] 
		public inkTextWidgetReference DistrictName
		{
			get => GetProperty(ref _districtName);
			set => SetProperty(ref _districtName, value);
		}

		[Ordinal(17)] 
		[RED("districtIcon")] 
		public inkImageWidgetReference DistrictIcon
		{
			get => GetProperty(ref _districtIcon);
			set => SetProperty(ref _districtIcon, value);
		}

		[Ordinal(18)] 
		[RED("districtFluffIcon")] 
		public inkImageWidgetReference DistrictFluffIcon
		{
			get => GetProperty(ref _districtFluffIcon);
			set => SetProperty(ref _districtFluffIcon, value);
		}
	}
}

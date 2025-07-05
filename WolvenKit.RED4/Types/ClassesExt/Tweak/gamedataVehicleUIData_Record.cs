
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleUIData_Record
	{
		[RED("driveLayout")]
		[REDProperty(IsIgnored = true)]
		public CString DriveLayout
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("horsepower")]
		[REDProperty(IsIgnored = true)]
		public CFloat Horsepower
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("info")]
		[REDProperty(IsIgnored = true)]
		public CString Info
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("mass")]
		[REDProperty(IsIgnored = true)]
		public CFloat Mass
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("productionYear")]
		[REDProperty(IsIgnored = true)]
		public CString ProductionYear
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}

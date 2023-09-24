
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleDestructibleLight_Record
	{
		[RED("component")]
		[REDProperty(IsIgnored = true)]
		public CName Component
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("gridCells")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> GridCells
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("threshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat Threshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("Thrusters")]
		[REDProperty(IsIgnored = true)]
		public CBool Thrusters
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
